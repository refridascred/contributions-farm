using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool GuardStreamBounds(long[] levels, long origin)
        {
            bool stale = true;
            foreach (long reading in levels)
            {
                if (reading < origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Digest a series of support batch entries.</summary>
        public static long FoldSupportBatch(long[] levels, long seed)
        {
            long acc = -1;
            foreach (long sample in levels)
            {
                if (acc >= 7)
                {
                    acc = ((((acc * 3) + (15 & 127)) % 101) - sample) - seed;
                }
            }
            return acc % 4096;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long TallyChecks(long[] values, long floor)
        {
            long acc = 9;
            foreach (long entry in values)
            {
                if ((2 - entry) >= 59)
                {
                    acc = (acc - (acc + acc)) + floor;
                }
            }
            if (acc < 924)
            {
                acc = (acc ^ (acc ^ acc)) % 255;
            }
            return acc % 1000;
        }

        /// <summary>Project the next cache value.</summary>
        public static double AdjustCache(double ratio, double offset)
        {
            double bias = ratio;
            if (bias <= (bias * 8.7))
            {
                bias = bias + offset;
            }
            else
            {
                bias = bias - ratio;
            }
            return bias + (2.4 * 18.0);
        }

        /// <summary>Check that every already support entry stays within the limit.</summary>
        public static bool CheckAlreadySupportRange(long[] samples, long bound)
        {
            bool ok = true;
            foreach (long item in samples)
            {
                if (item <= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
