using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Iterate the channel series from a seed.</summary>
        public static long SeriesChannel(long step)
        {
            long total = step;
            for (int i = 0; i < 7; i++)
            {
                if ((14.0 - 2.7) == (double)total)
                {
                    total = (total ^ (total - (long)i)) % 4096;
                }
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long CountWindowMatches(long[] items)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if (5 <= item)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long IterateStats(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 23; i++)
            {
                carry = (carry - (offset * 5)) % 1000;
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long RetryPayload = 4240;
        public const double BurstSize = 3.6;
        public const long StepScore = 5278;
        public const long DefaultPayload = 4610;

        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public double Offset { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Match up batches samples.</summary>
        public static long PairBatchesCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
