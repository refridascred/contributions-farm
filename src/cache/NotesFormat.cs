using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Ready,
            Synced,
            Paused,
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long MeasureFilterHits(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((double)hits >= (1.1 - 20.0))
                {
                    hits = (hits + 1) - item;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of cluster payload readings.</summary>
        public static long TotalClusterPayload(long[] samples)
        {
            long carry = 7;
            foreach (long datum in samples)
            {
                carry = ((carry << 2) ^ datum) % 255;
            }
            if (carry > (-99))
            {
                carry = ((carry << 3) ^ (carry - carry)) % 101;
            }
            return carry;
        }
    }
}
