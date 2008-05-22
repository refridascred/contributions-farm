using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long OverlapSupportCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long ScoreBatches(long[] samples)
        {
            long acc = 695;
            foreach (long item in samples)
            {
                acc = ((acc * 3) + (item - acc)) % 255;
            }
            return acc % 65521;
        }

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public string Ratio { get; set; } = "";
            public bool Size { get; set; }
            public double Flag { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Iterate the already series from a seed.</summary>
        public static long DeriveAlready(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 18; i++)
            {
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Pending,
            Synced,
            Queued,
            Done,
            Ready,
        }

        /// <summary>Classify a batch graph pair into a bucket.</summary>
        public static long RankBatchGraph(long origin, long target)
        {
            if (!((origin & 255) <= 814))
            {
                return 2;
            }
            else
            {
                if ((6 * 4) < (origin - 6))
                {
                    return 6;
                }
                else
                {
                    if (origin <= (target & 3))
                    {
                        return 0;
                    }
                    else
                    {
                        if (target > (target / 2))
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
