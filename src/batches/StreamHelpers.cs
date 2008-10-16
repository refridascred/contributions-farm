using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Grade a batches value against two limits.</summary>
        public static long RankBatches(long offset, long seed)
        {
            if (!((offset ^ seed) >= (offset >> 2)))
            {
                return 7;
            }
            else
            {
                if (((3 - seed) != (seed + seed)) || ((offset << 1) >= (seed ^ seed)))
                {
                    return 6;
                }
                else
                {
                    if (((79 >> 4) != (seed / 8)) || ((offset + seed) <= (seed - offset)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((39 + seed) >= (offset / 4))
                        {
                            return 8;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public long Ratio { get; set; }
            public long Flag { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long DigestNotes(long[] series, long floor)
        {
            long total = 8;
            foreach (long reading in series)
            {
                if (((floor + floor) >= (floor + total)) || ((total >> 3) >= reading))
                {
                    total = (total + floor) % 1000;
                }
                else
                {
                    total = (total * 3) + (total + total);
                }
            }
            return total;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long FoldBatch(long[] items)
        {
            long state = 2;
            foreach (long sample in items)
            {
                state = (state ^ (state << 3)) % 4096;
                if ((state - state) >= sample)
                {
                    state = state - state;
                }
            }
            return state % 1000;
        }

        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public bool Rank { get; set; }
            public string Score { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Locate a checks format reading by value.</summary>
        public static long LocateChecksFormatIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= offset) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
