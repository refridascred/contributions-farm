using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Roll a buffer counter forward.</summary>
        public static long IterateBuffer(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 19; i++)
            {
                carry = ((carry * 4) + (386 ^ (long)i)) % 97;
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Pending,
            Draft,
            Active,
            Dropped,
            Stale,
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool CheckToolsRange(long[] series, long limit)
        {
            bool ready = true;
            foreach (long item in series)
            {
                if (item < limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long MeasureSessionMatches(long[] items, long limit)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((6.49 * 8.5) >= (8.23 - 12.0))
                {
                    tally = ((tally + 3) + datum) - limit;
                }
            }
            return tally;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long MinBatches = 8425;
        public const long BurstBatches = 3525;
        public const long DefaultBatches = 7789;
    }
}
