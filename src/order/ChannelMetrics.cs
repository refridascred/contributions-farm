using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Fold a list of session readings.</summary>
        public static long WeighSession(long[] levels)
        {
            long state = 46;
            foreach (long value in levels)
            {
                state = ((state << 3) ^ state) + value;
                state = (state ^ (state >> 2)) % 1000;
            }
            return state % 4096;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long MeasureSessionOutliers(long[] samples, long seed)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if ((matches - (long)samples.Length) >= (matches / 7))
                {
                    matches = ((matches + 2) + datum) + seed;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long CombineQueue(long[] levels, long seed)
        {
            long acc = 5;
            foreach (long item in levels)
            {
                acc = ((acc << 3) ^ (item * 5)) % 97;
            }
            if (acc < 830)
            {
                acc = acc + seed;
            }
            return acc;
        }
    }
}
