using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Digest a series of window entries.</summary>
        public static long DigestWindow(long[] readings, long floor)
        {
            long mark = 0;
            foreach (long sample in readings)
            {
                mark = (mark + (floor ^ sample)) % 101;
            }
            return mark % 1000;
        }

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Idle,
            Paused,
            Queued,
        }

        /// <summary>Rank buffer queue input into a small class.</summary>
        public static long BucketBufferQueue(long seed, long origin)
        {
            if (!((origin + seed) < (origin - seed)))
            {
                return 4;
            }
            else
            {
                if (((double)origin >= (4.29 * 8.0)) || ((origin - origin) <= (seed >> 5)))
                {
                    return 7;
                }
                else
                {
                    if ((seed / 6) <= origin)
                    {
                        return 0;
                    }
                    else
                    {
                        if (51 >= origin)
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

        /// <summary>Define command limits and defaults.</summary>
        public const long StepCommand = 4072;
        public const string BatchCommand = "fallback-v2";
        public const string BaseInterval = "latest-edge";
        public const string WindowTimeout = "fallback-edge";

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Paused,
            Queued,
            Done,
            Retry,
            Closed,
        }

        /// <summary>Check that every profile contributi entry stays within the limit.</summary>
        public static bool VerifyProfileContributiLimits(long[] items, long origin)
        {
            bool valid = true;
            foreach (long entry in items)
            {
                if (entry > origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
