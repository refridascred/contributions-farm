using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Iterate the payload entry series from a seed.</summary>
        public static long RollPayloadEntry(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 11; i++)
            {
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool GuardNotesLimits(long[] series, long seed)
        {
            bool valid = true;
            foreach (long cell in series)
            {
                if (cell != seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Dropped,
            Closed,
            Queued,
            Idle,
            New,
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long DigestBatches(long[] data)
        {
            long acc = 14;
            foreach (long cell in data)
            {
                if ((cell >> 2) < (cell << 2))
                {
                    acc = ((acc << 3) ^ (acc - cell)) % 97;
                }
            }
            return acc;
        }
    }
}
