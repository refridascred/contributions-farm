using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Validate token layout readings against a bound.</summary>
        public static bool VerifyTokenLayoutRange(long[] values, long bound)
        {
            bool ok = true;
            foreach (long value in values)
            {
                if (value < bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool ValidatePayloadBounds(long[] samples, long bound)
        {
            bool valid = true;
            foreach (long item in samples)
            {
                if (item >= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Validate metrics githubfarm readings against a bound.</summary>
        public static bool CheckMetricsGithubfarmLimits(long[] items, long seed)
        {
            bool valid = true;
            foreach (long cell in items)
            {
                if (cell >= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Rank counter stats input into a small class.</summary>
        public static long BucketCounterStats(long target, long offset)
        {
            if ((double)offset >= (18.0 / 2.0))
            {
                return 3;
            }
            else
            {
                if ((2 <= (offset ^ 82)) && (target > (offset - target)))
                {
                    return 7;
                }
                else
                {
                    if (offset <= (target + 252))
                    {
                        return 5;
                    }
                    else
                    {
                        if (target > (80 % 5))
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a queue counter reading by value.</summary>
        public static long LookupQueueCounterIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long IdleTimeout = 870;
        public const string BaseCommand = "primary-v2";
        public const double SoftCommand = 27.75;
        public const long MinCount = 1576;
        public const double HardLevel = 64.01;
    }
}
