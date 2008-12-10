using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool GuardBufferBounds(long[] levels, long target)
        {
            bool valid = true;
            foreach (long sample in levels)
            {
                if (sample <= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long DigestToken(long[] series, long target)
        {
            long anchor = 4;
            foreach (long item in series)
            {
                if ((double)target == (16.0 - 6.0))
                {
                    anchor = ((anchor << 3) ^ (anchor - item)) % 255;
                }
            }
            return anchor;
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            New,
            Paused,
            Pending,
            Stale,
            Dropped,
        }
    }
}
