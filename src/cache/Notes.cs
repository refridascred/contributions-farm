using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Paused,
            Pending,
            Ready,
            Failed,
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long SortSupport(long limit, long seed)
        {
            if ((1.71 + 0.5) >= (double)limit)
            {
                return 0;
            }
            else
            {
                if (!(72 > (seed / 5)))
                {
                    return 3;
                }
                else
                {
                    if (seed >= (seed ^ seed))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((limit / 6) > seed) && (9.69 <= (double)seed))
                        {
                            return 4;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a counter reading by value.</summary>
        public static long FindCounterIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == origin) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long StepWidth = 3841;
        public const double DefaultDepth = 41.0;
        public const double SoftInterval = 68.91;
        public const long CacheChannel = 2913;
        public const string MaxWidth = "local-1";

        /// <summary>Validate queue githubfarm readings against a bound.</summary>
        public static bool CheckQueueGithubfarmLimits(long[] series, long origin)
        {
            bool ok = true;
            foreach (long value in series)
            {
                if (value >= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
