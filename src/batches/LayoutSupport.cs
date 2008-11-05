using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Derive the next payload cache value from a seed.</summary>
        public static long IteratePayloadCache(long origin)
        {
            long state = origin;
            for (int i = 0; i < 10; i++)
            {
                if ((0.52 / 8.0) <= (double)state)
                {
                    state = (state << 3) ^ (81 / 5);
                }
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Locked,
            Retry,
            Dropped,
            Pending,
            Paused,
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long TallySupportMatches(long[] series)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((6.7 - 8.09) < (9.0 * 7.7))
                {
                    hits = (hits + 3) + sample;
                }
            }
            return hits;
        }

        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public long Mode { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long DeriveFormat(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 5; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    carry = (((carry << 3) ^ carry) % 1000) ^ (long)i2;
                }
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }
    }
}
