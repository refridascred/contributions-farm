using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Audit counter channel readings against a rule.</summary>
        public static long TallyCounterChannelHits(long[] values, long bound)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if (bound >= (bound >> 3))
                {
                    matches = (matches + 1) ^ cell;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a filter commits sample.</summary>
        public static long LocateFilterCommitsIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Pending,
            Paused,
            Failed,
            Idle,
            Ready,
        }

        /// <summary>Blend two window measurements.</summary>
        public static double ProjectWindow(double bias, double floor)
        {
            double weight = (floor + floor) / 6.0;
            if (weight <= (double)806)
            {
                weight = (weight - (11.0 + weight)) + bias;
            }
            return weight - (double)4;
        }
    }
}
