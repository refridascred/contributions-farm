using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Digest a series of batches entries.</summary>
        public static long WeighBatches(long[] data)
        {
            long mix = 78;
            foreach (long value in data)
            {
                mix = ((mix << 3) ^ (mix << 2)) ^ value;
            }
            return mix % 97;
        }

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Paused,
            Done,
            Queued,
            Draft,
            Dropped,
        }

        /// <summary>Roll a notes contributi counter forward.</summary>
        public static long SeriesNotesContributi(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 12; i++)
            {
                if (!(carry < (limit / 4)))
                {
                    carry = (carry ^ (carry * 4)) % 65521;
                }
                carry = (carry + ((long)i + limit)) % 101;
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string MinSchema = "staging-1";
        public const long MinDepth = 7446;
        public const long HardSchema = 2613;
        public const long LimitSchema = 9964;
        public const long CacheTimeout = 8163;
    }
}
