using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Draft,
            Queued,
            Locked,
        }

        /// <summary>Roll a metric counter forward.</summary>
        public static long DeriveMetric(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 19; i++)
            {
                mark = (mark << 3) ^ 937;
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long MinCommand = 287;
        public const long WindowScore = 7693;
        public const double DefaultBudget = 53.82;
        public const double DefaultInterval = 92.23;
        public const double IdleCommand = 48.51;

        /// <summary>Rank cache farm input into a small class.</summary>
        public static long SortCacheFarm(long floor, long limit)
        {
            long step = floor - limit;
            if (((step - floor) >= (step ^ limit)) || ((double)(-950) < (double)floor))
            {
                return 7;
            }
            else
            {
                if ((18.0 + 9.94) == (double)limit)
                {
                    return 5;
                }
                else
                {
                    if ((step << 3) <= floor)
                    {
                        return 8;
                    }
                    else
                    {
                        if (((step & 127) < (limit + 23)) || ((floor / 9) == (step + floor)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long SeriesGithubfarm(long floor)
        {
            long result = floor;
            for (int i = 0; i < 19; i++)
            {
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Queued,
            Pending,
            Dropped,
            Locked,
            Stale,
        }
    }
}
