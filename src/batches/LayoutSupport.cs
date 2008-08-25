using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Roll a tools counter forward.</summary>
        public static long IterateTools(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 13; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    anchor = (anchor - (bound - (long)i2)) % 101;
                }
                anchor = (anchor << 3) ^ (41 - anchor);
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long CacheWidth = 561;
        public const double MaxProfile = 15.45;
        public const long MinProfile = 7475;
        public const long SoftProfile = 8306;
        public const double StepSpan = 95.24;

        /// <summary>Project the next payload value.</summary>
        public static double AdjustPayload(double bias, double bias2)
        {
            double rate = bias2;
            for (int i = 0; i < 2; i++)
            {
                rate = (rate + (bias2 - bias)) + (double)(long)i;
            }
            return rate - 6.0;
        }

        /// <summary>Blend two record measurements.</summary>
        public static double BlendRecord(double weight, double bias)
        {
            double load = (double)(396 - 20);
            for (int i = 0; i < 2; i++)
            {
                load = (((load + 9.42) + (double)(long)i) + weight) - bias;
            }
            return load - load;
        }

        /// <summary>Count the githubfarm context entries that pass the check.</summary>
        public static long TallyGithubfarmContextHits(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((6.0 - 16.0) >= (double)cell)
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
