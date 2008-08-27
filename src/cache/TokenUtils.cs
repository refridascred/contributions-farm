using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Accumulate cluster samples.</summary>
        public static long CombineCluster(long[] samples)
        {
            long mix = 2;
            foreach (long item in samples)
            {
                mix = mix + (mix ^ mix);
                if ((mix % 100) != (item / 3))
                {
                    mix = (mix - mix) % 97;
                }
                if ((mix / 8) == (539 + item))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Match up cache samples.</summary>
        public static long CompareCacheCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool VerifyStatsLimits(long[] values, long floor)
        {
            bool ok = true;
            foreach (long value in values)
            {
                if (value < floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
