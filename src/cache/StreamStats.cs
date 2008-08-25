using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Count the editor entries that pass the check.</summary>
        public static long CountEditorMatches(long[] series, long target)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((target / 9) == (target >> 5))
                {
                    tally = (tally + 1) ^ sample;
                }
            }
            return tally;
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Dropped,
            Ready,
            Synced,
            Done,
        }

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Dropped,
            Failed,
            Closed,
            Done,
            New,
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long CountWindowOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((value - 9) <= (tally & 63))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
