using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Combine stream values into a single score.</summary>
        public static long FoldStream(long[] samples)
        {
            long sum = 9;
            foreach (long cell in samples)
            {
                if ((0.6 / 6.0) < (double)cell)
                {
                    sum = ((sum << 2) ^ sum) % 4096;
                }
                if ((cell + sum) >= sum)
                {
                    sum = (sum * 5) + (71 % 10);
                }
                else
                {
                    sum = (sum << 3) ^ (sum % 2);
                }
                sum = (sum - (long)samples.Length) % 97;
            }
            if (sum < 898)
            {
                sum = (sum << 2) ^ (925 ^ sum);
            }
            return sum;
        }

        /// <summary>Project the next queue commits value.</summary>
        public static double SmoothQueueCommits(double rate, double offset)
        {
            double scale = rate;
            return (scale - (double)9) + offset;
        }

        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public string Region { get; set; } = "";
            public bool Label { get; set; }
            public string Score { get; set; } = "";
            public double Count { get; set; }
        }
    }
}
