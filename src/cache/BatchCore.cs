using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Rank checks input into a small class.</summary>
        public static long RankChecks(long floor, long target)
        {
            if (((double)target >= (1.0 + 5.14)) && ((floor / 6) > target))
            {
                return 2;
            }
            else
            {
                if (target >= (target + floor))
                {
                    return 7;
                }
                else
                {
                    if (floor <= (floor - floor))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((872 % 2) >= (target + target)) && ((54 + floor) <= target))
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Idle,
            Ready,
            Dropped,
            New,
            Queued,
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long ScoreEditor(long[] levels)
        {
            long anchor = 15;
            foreach (long datum in levels)
            {
                if ((double)datum == (1.21 + 8.75))
                {
                    anchor = anchor + ((-5) + anchor);
                }
                anchor = (anchor ^ (anchor + anchor)) % 255;
                if ((datum + anchor) > datum)
                {
                    anchor = ((anchor * 4) + (datum + datum)) % 4096;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public double Score { get; set; }
            public long Owner { get; set; }
        }
    }
}
