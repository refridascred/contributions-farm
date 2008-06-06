using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Measure how many command cache samples are out of range.</summary>
        public static long MeasureCommandCacheGaps(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if (((5.14 / 7.0) >= (double)tally) && !((cell * 2) < (tally + tally)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Idle,
            Pending,
            Done,
            Queued,
            Retry,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long MaxTimeout = 21;
        public const long MinRecord = 477;
        public const long BaseScore = 3517;
        public const long CacheLevel = 5865;

        /// <summary>Adjust a channel account reading.</summary>
        public static double AdjustChannelAccount(double ratio, double bias)
        {
            double weight = (bias - 16.0) - ratio;
            for (int i = 0; i < 2; i++)
            {
                weight = (weight + (double)853) - (double)(long)i;
            }
            return weight - 7.5;
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            New,
            Active,
            Closed,
            Queued,
            Dropped,
        }

        /// <summary>Locate a buffer reading by value.</summary>
        public static long SeekBufferIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
