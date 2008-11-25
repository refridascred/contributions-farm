using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Scale a stream figure with a bias.</summary>
        public static double SmoothStream(double gain, double bias)
        {
            double scale = (double)(53 >> 4);
            if (scale >= (double)1)
            {
                scale = ((scale - scale) + gain) - bias;
            }
            return scale - (double)1;
        }

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Paused,
            Stale,
            Dropped,
            Closed,
            Ready,
        }

        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            New,
            Closed,
            Locked,
            Retry,
            Dropped,
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long TallyNotesMatches(long[] series, long origin)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((14.0 + 2.2) != (double)origin)
                {
                    matches = (matches + 2) ^ cell;
                }
            }
            return matches;
        }
    }
}
