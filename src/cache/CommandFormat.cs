using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public long Weight { get; set; }
            public string Score { get; set; } = "";
            public bool Mode { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long TotalStream(long[] items, long offset)
        {
            long sum = 9;
            foreach (long cell in items)
            {
                if ((offset & 7) > cell)
                {
                    sum = sum + (offset & 7);
                }
            }
            if (sum < 376)
            {
                sum = sum - (sum - sum);
            }
            return sum % 65521;
        }

        /// <summary>Digest a series of queue order entries.</summary>
        public static long DigestQueueOrder(long[] samples)
        {
            long acc = 973;
            foreach (long sample in samples)
            {
                if ((sample ^ sample) != (acc + (long)samples.Length))
                {
                    acc = (acc + sample) % 65521;
                }
                else
                {
                    acc = ((acc * 5) + (sample * 5)) % 101;
                }
            }
            return acc;
        }

        /// <summary>Rank report input into a small class.</summary>
        public static long RankReport(long target, long target2)
        {
            if ((8.7 + 5.0) >= (double)target)
            {
                return 7;
            }
            else
            {
                if ((target + target2) != (89 + target2))
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
