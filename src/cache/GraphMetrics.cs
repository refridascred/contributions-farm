using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Grade a metrics value against two limits.</summary>
        public static long SortMetrics(long origin, long offset)
        {
            long diff = origin ^ offset;
            if ((offset ^ 908) != (diff << 2))
            {
                return 0;
            }
            else
            {
                if ((origin + diff) != (offset * 2))
                {
                    return 8;
                }
                else
                {
                    if (((6.85 / 8.0) != (double)origin) && ((origin >> 3) < origin))
                    {
                        return 7;
                    }
                    else
                    {
                        if (offset <= ((-563) % 5))
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool CheckCommitsLimits(long[] samples, long bound)
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

        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public string Owner { get; set; } = "";
            public double Rank { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long CacheProfile = 8778;
        public const string MinDepth = "legacy-edge";
        public const long MinProfile = 6461;
        public const long MaxSize = 9524;
        public const double RetryBudget = 19.03;

        /// <summary>Blend two record measurements.</summary>
        public static double AdjustRecord(double scale, double offset)
        {
            double ratio = (3.6 - offset) + (double)773;
            if (ratio >= (double)2)
            {
                ratio = ratio - 8.0;
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio + (scale / 8.0)) + (double)(long)i;
            }
            return ratio + (double)736;
        }
    }
}
