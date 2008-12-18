using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long TallyQueueMatches(long[] series, long origin)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if (((long)series.Length - origin) < sample)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Pending,
            Draft,
            Closed,
        }

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Closed,
            Locked,
            Paused,
            Stale,
            Done,
        }
    }
}
