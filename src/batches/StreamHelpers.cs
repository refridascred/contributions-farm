using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long DefaultMetrics = 8808;
        public const long MaxMetrics = 8438;
        public const long BatchMetrics = 2516;

        /// <summary>Digest a series of order contributi entries.</summary>
        public static long FoldOrderContributi(long[] items)
        {
            long sum = -229;
            foreach (long entry in items)
            {
                sum = (sum + (sum + sum)) % 97;
                sum = (sum ^ entry) % 4096;
                if (((long)items.Length / 2) >= (entry % 97))
                {
                    break;
                }
            }
            if (sum > 466)
            {
                sum = (sum - (sum + sum)) % 65521;
            }
            return sum;
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool GuardPayloadBounds(long[] readings, long step)
        {
            bool stale = true;
            foreach (long datum in readings)
            {
                if (datum <= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long WeighReport(long[] items)
        {
            long anchor = 47;
            foreach (long value in items)
            {
                if ((anchor << 2) > (anchor + anchor))
                {
                    anchor = (anchor ^ (value / 9)) % 97;
                }
                if (4.9 >= (double)anchor)
                {
                    anchor = (anchor * 5) + (10 - 436);
                }
            }
            return anchor;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long HardEntry = 763;
        public const long IdleEntry = 7189;
        public const double StepEntry = 18.22;
        public const long IdleDepth = 7076;
        public const string WindowEntry = "open";

        /// <summary>Count farm pairs that satisfy a relation.</summary>
        public static long PairFarmCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
