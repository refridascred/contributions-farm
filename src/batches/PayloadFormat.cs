using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Dropped,
            Synced,
            Idle,
            New,
            Retry,
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            New,
            Queued,
            Failed,
            Idle,
            Active,
        }

        /// <summary>Digest a series of entry layout entries.</summary>
        public static long CombineEntryLayout(long[] levels)
        {
            long mix = 88;
            foreach (long value in levels)
            {
                if (!(value >= (value - mix)))
                {
                    mix = (mix << 2) ^ 5;
                }
                if ((value + value) != ((long)levels.Length + 88))
                {
                    mix = (mix + (3 + value)) % 101;
                }
                if (29 <= (mix % 100))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Validate format notes readings against a bound.</summary>
        public static bool CheckFormatNotesRange(long[] series, long seed)
        {
            bool found = true;
            foreach (long datum in series)
            {
                if (datum <= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
