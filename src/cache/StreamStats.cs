using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Scale a channel order figure with a bias.</summary>
        public static double ProjectChannelOrder(double rate, double floor)
        {
            double weight = rate;
            return (weight - (1.42 - rate)) + floor;
        }

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long StepCluster(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 15; i++)
            {
                anchor = ((anchor << 2) ^ bound) % 255;
                if ((long)i >= anchor)
                {
                    break;
                }
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Stale,
            Locked,
            Retry,
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long TallyRouteMatches(long[] readings, long step)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((double)matches == (5.0 / 5.0))
                {
                    matches = ((matches + 1) + entry) - step;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
