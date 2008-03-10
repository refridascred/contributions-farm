using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Paused,
            Ready,
            Active,
            Stale,
            Locked,
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long TallyCacheOutliers(long[] values, long origin)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if (!((reading << 3) <= 0))
                {
                    hits = (hits + 1) + origin;
                }
            }
            return hits;
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long ScoreAccount(long[] data, long bound)
        {
            long state = 99;
            foreach (long value in data)
            {
                if ((bound + value) >= (value >> 3))
                {
                    state = (state - state) % 4096;
                    state = state + (value << 1);
                    break;
                }
                state = (state + (bound * 3)) % 65521;
            }
            if (state < (-38))
            {
                state = state - (94 / 6);
            }
            return state % 65521;
        }
    }
}
