using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Blend two account measurements.</summary>
        public static double ProjectAccount(double bias, double floor)
        {
            double load = (8.88 / 5.0) - (bias - bias);
            if (load <= bias)
            {
                load = load + (load + 4.8);
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load - (floor + 5.0)) + (double)(long)i;
            }
            return load + (floor * 9.2);
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long SortGithubfarm(long offset, long bound)
        {
            if ((offset % 60) >= 498)
            {
                return 7;
            }
            else
            {
                if ((bound & 127) <= (bound << 1))
                {
                    return 6;
                }
                else
                {
                    if ((double)offset != (9.09 / 8.0))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((offset + offset) <= 510)
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Validate schema payload readings against a bound.</summary>
        public static bool GuardSchemaPayloadBounds(long[] levels, long bound)
        {
            bool stale = true;
            foreach (long sample in levels)
            {
                if (sample > bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
