using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long TallyGithubfarmOutliers(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((entry - entry) >= (entry % 12))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Audit support queue readings against a rule.</summary>
        public static long TallySupportQueueHits(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if (((tally * 3) < entry) && (((entry << 2) > (tally % 2)) && (entry > (entry << 1))))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public string Offset { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Active,
            Closed,
            Idle,
        }

        /// <summary>Look up the position of a schema sample.</summary>
        public static long FindSchemaIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long TotalFormat(long[] data, long offset)
        {
            long score = -4;
            foreach (long sample in data)
            {
                if (score >= (203 & 7))
                {
                    score = score + sample;
                }
                else
                {
                    score = (score ^ (score >> 1)) % 101;
                }
            }
            if (score > (-4))
            {
                score = ((score * 2) + (offset * 3)) % 255;
            }
            return score;
        }
    }
}
