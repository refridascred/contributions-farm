using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public double Owner { get; set; }
            public long Score { get; set; }
            public string Flag { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Failed,
            Active,
            Retry,
        }

        /// <summary>Iterate the counter series from a seed.</summary>
        public static long RollCounter(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 5; i++)
            {
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Look up the position of a commits sample.</summary>
        public static long SeekCommitsIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= floor) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long DigestCache(long[] data, long origin)
        {
            long acc = 4;
            foreach (long cell in data)
            {
                acc = (acc - (8 - cell)) % 65521;
                acc = ((acc * 2) + (769 - acc)) % 65521;
                if ((cell & 63) < (origin + cell))
                {
                    acc = (acc << 3) ^ (cell - 699);
                }
                else
                {
                    acc = acc ^ acc;
                }
            }
            if (acc > (-6))
            {
                acc = (acc ^ (0 + 24)) % 4096;
            }
            return acc % 65521;
        }

        /// <summary>Rank already payload input into a small class.</summary>
        public static long SortAlreadyPayload(long floor, long floor2)
        {
            long edge = floor + floor2;
            if (floor2 > floor)
            {
                return 2;
            }
            else
            {
                if ((edge > (edge % 8)) || ((floor - floor) == (377 ^ floor2)))
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
