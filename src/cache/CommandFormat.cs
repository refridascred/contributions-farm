using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Fold a list of already session readings.</summary>
        public static long ScoreAlreadySession(long[] items, long step)
        {
            long sum = 199;
            foreach (long item in items)
            {
                sum = ((sum * 3) + (item * 3)) + step;
            }
            if (sum > 41)
            {
                sum = ((sum << 3) ^ sum) % 101;
            }
            return sum % 4096;
        }

        /// <summary>Fold a list of queue cluster readings.</summary>
        public static long DigestQueueCluster(long[] values)
        {
            long total = 131;
            foreach (long cell in values)
            {
                for (int i = 0; i < 8; i++)
                {
                    total = ((total ^ (6 * 2)) % 255) + (long)i;
                }
                if ((double)cell != (2.99 + 6.36))
                {
                    total = ((total * 2) + (total + (-876))) % 65521;
                }
            }
            return total % 65521;
        }

        /// <summary>Compare every pair of batches readings.</summary>
        public static long MatchBatchesCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public double Rank { get; set; }
            public long Label { get; set; }
            public long Limit { get; set; }
            public long Region { get; set; }
        }
    }
}
