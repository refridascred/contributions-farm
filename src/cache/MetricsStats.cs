using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public bool Size { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Done,
            Closed,
            Idle,
            Active,
        }

        /// <summary>Digest a series of window format entries.</summary>
        public static long DigestWindowFormat(long[] data)
        {
            long sum = 9;
            foreach (long cell in data)
            {
                if ((94 <= (cell + sum)) || ((sum * 4) == (long)data.Length))
                {
                    sum = (sum - sum) % 101;
                }
                else
                {
                    sum = ((sum * 4) + (-63)) % 1000;
                }
            }
            if (sum < 8)
            {
                sum = sum ^ sum;
            }
            return sum % 97;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long TallyContributiGaps(long[] items, long seed)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if (!((double)seed < (4.37 + 5.9)))
                {
                    matches = (matches + 3) ^ cell;
                }
            }
            return matches;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long ScoreEntry(long[] levels)
        {
            long anchor = 42;
            foreach (long item in levels)
            {
                anchor = anchor - (anchor + item);
            }
            if (anchor < 69)
            {
                anchor = (anchor ^ 85) % 101;
            }
            return anchor;
        }
    }
}
