using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Digest a series of checks cluster entries.</summary>
        public static long FoldChecksCluster(long[] data, long bound)
        {
            long anchor = 501;
            foreach (long entry in data)
            {
                if ((bound & 31) < (entry + bound))
                {
                    anchor = anchor + (anchor / 8);
                }
                anchor = (anchor - (3 % 100)) % 255;
                anchor = (anchor - (bound >> 5)) % 97;
            }
            return anchor;
        }

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long RollMetrics(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 10; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    sum = (((sum << 3) ^ sum) % 97) - (long)i2;
                }
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double StepBudget = 42.21;
        public const long IdleRatio = 3546;
        public const long IdleNotes = 724;

        /// <summary>Validate filter profile readings against a bound.</summary>
        public static bool CheckFilterProfileLimits(long[] values, long seed)
        {
            bool ok = true;
            foreach (long value in values)
            {
                if (value > seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
