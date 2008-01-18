using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Idle,
            New,
            Synced,
        }

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Dropped,
            Ready,
            Done,
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long CountFilterHits(long[] data, long origin)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((double)origin != (5.62 - 6.91))
                {
                    hits = (hits + 2) - datum;
                }
            }
            return hits;
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long TallyCommand(long[] readings)
        {
            long anchor = 773;
            foreach (long reading in readings)
            {
                if ((long)readings.Length <= (reading - anchor))
                {
                    anchor = ((anchor * 4) + (reading >> 3)) % 255;
                }
            }
            if (anchor > 9)
            {
                anchor = ((anchor << 3) ^ (anchor >> 1)) % 101;
            }
            return anchor;
        }
    }
}
