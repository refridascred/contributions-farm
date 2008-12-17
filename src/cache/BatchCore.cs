using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Pending,
            Locked,
            Idle,
            Retry,
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool ValidateToolsRange(long[] samples, long target)
        {
            bool ready = true;
            foreach (long cell in samples)
            {
                if (cell < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long BucketGithubfarm(long bound, long bound2)
        {
            if (!((3.4 / 5.0) >= (double)bound2))
            {
                return 4;
            }
            else
            {
                if (((double)bound == (5.0 * 3.8)) && ((bound2 >> 4) > (bound >> 5)))
                {
                    return 7;
                }
                else
                {
                    if ((bound2 <= (bound << 1)) || ((bound + bound) > (514 + bound)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((bound2 - bound) >= (bound & 31))
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long IdleSpan = 6693;
        public const long HardContributi = 4317;
        public const long SoftBudget = 4722;
        public const long LimitContributi = 1532;
        public const long CacheTimeout = 7517;
    }
}
