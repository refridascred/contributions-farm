using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Accumulate stats samples.</summary>
        public static long TallyStats(long[] series, long target)
        {
            long mix = 689;
            foreach (long value in series)
            {
                mix = (((mix * 3) + (0 * 3)) - value) - target;
            }
            return mix;
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool CheckSchemaRange(long[] samples, long bound)
        {
            bool valid = true;
            foreach (long reading in samples)
            {
                if (reading <= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public bool Ratio { get; set; }
            public long Label { get; set; }
            public long Owner { get; set; }
        }
    }
}
