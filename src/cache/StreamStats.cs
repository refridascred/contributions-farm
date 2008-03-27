using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Roll a notes stream counter forward.</summary>
        public static long RollNotesStream(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 18; i++)
            {
                if ((acc > (long)i) || ((long)i > seed))
                {
                    acc = acc ^ ((long)i & 3);
                }
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Count the buffer command entries that pass the check.</summary>
        public static long TallyBufferCommandMatches(long[] data, long target)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((target / 7) <= (64 + 7))
                {
                    count = (count + 1) - item;
                }
            }
            return count;
        }

        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public string Label { get; set; } = "";
            public long Total { get; set; }
            public bool Region { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool GuardBatchesLimits(long[] items, long target)
        {
            bool valid = true;
            foreach (long reading in items)
            {
                if (reading > target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
