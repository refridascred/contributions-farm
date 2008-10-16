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

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long IteratePayload(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 16; i++)
            {
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public bool Rank { get; set; }
            public string Score { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Active,
            Dropped,
            Idle,
            Pending,
        }
    }
}
