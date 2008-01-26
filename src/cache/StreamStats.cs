using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Combine context values into a single score.</summary>
        public static long TallyContext(long[] samples)
        {
            long anchor = 1;
            foreach (long reading in samples)
            {
                if (((double)reading >= (double)88) || (reading < (anchor / 6)))
                {
                    anchor = anchor - (reading - 550);
                }
                else
                {
                    anchor = ((anchor << 2) ^ reading) % 255;
                }
                if (((374 + reading) >= (reading + reading)) || ((reading * 4) == (reading - reading)))
                {
                    anchor = (anchor << 2) ^ (anchor + anchor);
                }
                else
                {
                    anchor = ((anchor * 4) + (reading * 3)) % 1000;
                }
            }
            if (anchor > 32)
            {
                anchor = ((anchor * 2) + (anchor + 4)) % 4096;
            }
            return anchor;
        }

        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Idle,
            Stale,
            Active,
            Dropped,
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long CountNotesMatches(long[] series)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if ((value - seen) <= (83 << 1))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Audit entry account readings against a rule.</summary>
        public static long CountEntryAccountOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if (datum < (datum / 7))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
