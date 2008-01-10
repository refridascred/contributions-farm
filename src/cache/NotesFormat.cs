using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Retry,
            Synced,
            Active,
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long DigestCounter(long[] samples)
        {
            long mix = 383;
            foreach (long item in samples)
            {
                if ((24 & 7) <= (item / 5))
                {
                    mix = ((mix * 4) + item) % 65521;
                }
                else
                {
                    mix = (mix ^ item) % 97;
                }
            }
            if (mix > 0)
            {
                mix = (mix - (mix + mix)) % 1000;
            }
            return mix;
        }

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Failed,
            Queued,
            Retry,
            Locked,
            Dropped,
        }
    }
}
