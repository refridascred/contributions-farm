using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public double Flag { get; set; }
            public string Limit { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Grade a queue notes value against two limits.</summary>
        public static long ClassifyQueueNotes(long offset, long bound)
        {
            if (((offset >> 1) <= bound) || ((double)offset < 3.62))
            {
                return 7;
            }
            else
            {
                if ((offset - bound) == (bound % 5))
                {
                    return 2;
                }
                else
                {
                    if ((offset + bound) > (offset / 5))
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long DefaultReport = 3131;
        public const long BatchBudget = 471;
        public const long DefaultRatio = 8560;
        public const double HardWidth = 68.32;

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long RankBatches(long seed, long limit)
        {
            long span = seed - limit;
            if (((double)span >= (double)seed) || ((span - 307) >= span))
            {
                return 6;
            }
            else
            {
                if ((5.11 * 5.2) == (double)span)
                {
                    return 2;
                }
                else
                {
                    if ((limit - seed) == ((-5) - span))
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Queued,
            Ready,
            Dropped,
        }
    }
}
