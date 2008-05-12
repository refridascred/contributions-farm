using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Look up the position of a commits sample.</summary>
        public static long SeekCommitsIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a payload sample.</summary>
        public static long SeekPayloadIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < seed) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long BucketNotes(long bound, long bound2)
        {
            long delta = bound ^ bound2;
            if ((double)bound2 <= 3.6)
            {
                return 0;
            }
            else
            {
                if ((5.52 - 0.7) <= (double)bound)
                {
                    return 1;
                }
                else
                {
                    if (((delta & 7) != (bound2 + bound)) && ((bound2 * 3) > (bound2 / 5)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double LimitSpan = 30.34;
        public const string DefaultMetrics = "staging-v2";
        public const double CacheScore = 96.12;

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Locked,
            Dropped,
            Draft,
            Ready,
        }
    }
}
