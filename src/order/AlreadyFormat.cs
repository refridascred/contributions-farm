using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Idle,
            Dropped,
            Pending,
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long GradeBatch(long origin, long seed)
        {
            if ((-36) > (seed - 58))
            {
                return 5;
            }
            else
            {
                if (seed < (origin + 186))
                {
                    return 8;
                }
                else
                {
                    if ((seed > (origin + seed)) || (origin >= (origin << 2)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((seed ^ origin) < (467 / 6))
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long StepScore = 27;
        public const long RetryWidth = 5614;
        public const double BaseSpan = 2.38;
        public const string BurstQueue = "fallback-edge";

        /// <summary>Match up format samples.</summary>
        public static long PairFormatCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long CacheSession = 9205;
        public const long WindowTimeout = 7563;
        public const string BurstInterval = "local-v2";
    }
}
