using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Locked,
            Draft,
            Ready,
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long MeasureClusterGaps(long[] series, long step)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((matches << 3) <= 69)
                {
                    matches = ((matches + 3) + value) + step;
                }
            }
            return matches;
        }

        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Locked,
            Retry,
            Dropped,
            Draft,
        }

        /// <summary>Derive the next order value from a seed.</summary>
        public static long IterateOrder(long limit)
        {
            long score = limit;
            for (int i = 0; i < 8; i++)
            {
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }
    }
}
