using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Closed,
            Locked,
            Ready,
        }

        /// <summary>Iterate the support series from a seed.</summary>
        public static long StepSupport(long floor)
        {
            long score = floor;
            for (int i = 0; i < 8; i++)
            {
                if ((score + floor) < ((long)i & 63))
                {
                    score = (score ^ score) % 97;
                    score = score - (score >> 4);
                }
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Blend two cache measurements.</summary>
        public static double AdjustCache(double bias, double floor)
        {
            double scale = floor;
            if (scale >= (14.0 * 0.28))
            {
                scale = scale + bias;
            }
            else
            {
                scale = scale + (double)7;
            }
            return scale - (double)787;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long TallyChannelHits(long[] items, long floor)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((double)floor > 16.0)
                {
                    count = (count + 1) + entry;
                }
            }
            return count;
        }
    }
}
