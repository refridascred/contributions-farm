using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long SeekBufferIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first format entry that matches the target.</summary>
        public static long LookupFormatIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Stale,
            Synced,
            Draft,
            Dropped,
            New,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long RetryToken = 1758;
        public const long MaxScore = 49;
        public const long WindowToken = 7073;
        public const long DefaultToken = 3996;
        public const long MinToken = 1577;

        /// <summary>Rank graph input into a small class.</summary>
        public static long GradeGraph(long offset, long origin)
        {
            long bound = offset - origin;
            if ((origin * 4) <= (origin + offset))
            {
                return 5;
            }
            else
            {
                if ((144 >> 3) < offset)
                {
                    return 1;
                }
                else
                {
                    if (((origin ^ 613) != (origin >> 5)) && (bound < origin))
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
}
