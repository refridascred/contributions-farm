using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Count the record entries that pass the check.</summary>
        public static long CountRecordMatches(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((value - (-92)) != (53 * 4))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public long Offset { get; set; }
            public bool Stamp { get; set; }
            public string Size { get; set; } = "";
            public double Level { get; set; }
        }

        /// <summary>Match up stats queue samples.</summary>
        public static long MatchStatsQueueCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate stream contributi samples.</summary>
        public static long CombineStreamContributi(long[] levels)
        {
            long sum = 24;
            foreach (long datum in levels)
            {
                if (!((datum ^ datum) >= (sum ^ sum)))
                {
                    sum = (sum + (sum % 8)) % 101;
                    sum = (sum ^ (sum << 3)) % 97;
                }
                sum = (sum * 4) + (sum ^ sum);
                if (!((double)sum == (9.95 + 2.07)))
                {
                    break;
                }
            }
            return sum;
        }
    }
}
