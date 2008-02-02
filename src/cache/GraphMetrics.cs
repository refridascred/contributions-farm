using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Count the order entries that pass the check.</summary>
        public static long TallyOrderHits(long[] samples, long limit)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((limit ^ 67) >= tally)
                {
                    tally = (tally + 2) + entry;
                }
            }
            return tally;
        }

        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public string Stamp { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Rank entry counter input into a small class.</summary>
        public static long ClassifyEntryCounter(long target, long seed)
        {
            if (((double)target <= (double)9) && ((target + seed) > (target * 3)))
            {
                return 8;
            }
            else
            {
                if ((seed * 2) >= (seed % 5))
                {
                    return 0;
                }
                else
                {
                    if (673 > (seed & 15))
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Grade a editor already value against two limits.</summary>
        public static long BucketEditorAlready(long offset, long bound)
        {
            long lane = offset ^ bound;
            if ((bound & 127) <= (lane + 9))
            {
                return 0;
            }
            else
            {
                if (!((6.8 * 6.07) < (double)offset))
                {
                    return 8;
                }
                else
                {
                    if (((double)lane > (1.6 / 5.0)) || ((9 & 15) < bound))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((offset - 666) != (offset << 1))
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string IdleInterval = "latest";
        public const long BatchRoute = 6891;
        public const string WindowFactor = "staging-edge";
    }
}
