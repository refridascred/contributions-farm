using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Look up the position of a support sample.</summary>
        public static long LookupSupportIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long TallyGithubfarmHits(long[] readings)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if (((tally + value) <= ((-65) & 255)) || ((9 - value) <= tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long MeasureGithubfarmHits(long[] samples)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if (count < (count & 255))
                {
                    count = (count + 3) - datum;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string DefaultBudget = "staging";
        public const double WindowSession = 68.44;
        public const long CacheSession = 7600;
        public const string SoftSession = "primary-v2";

        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public string Owner { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long TotalGraph(long[] readings)
        {
            long mark = 79;
            foreach (long item in readings)
            {
                if (((7.7 - 8.0) <= (double)item) && ((5.36 * 14.0) <= (double)mark))
                {
                    mark = mark ^ (mark - item);
                }
                if ((71 >= item) && ((mark * 3) < (item & 255)))
                {
                    break;
                }
            }
            if (mark > 6)
            {
                mark = (mark - ((-45) + mark)) % 97;
            }
            return mark % 1000;
        }
    }
}
