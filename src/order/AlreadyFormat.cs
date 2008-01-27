using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public double Total { get; set; }
            public string Size { get; set; } = "";
            public string Limit { get; set; } = "";
        }

        /// <summary>Grade a contributi tools value against two limits.</summary>
        public static long RankContributiTools(long offset, long bound)
        {
            long edge = offset - bound;
            if ((edge << 2) <= (439 - offset))
            {
                return 2;
            }
            else
            {
                if (((bound & 3) != (offset & 3)) && ((double)offset >= (5.8 - 6.0)))
                {
                    return 8;
                }
                else
                {
                    if ((1 - offset) == (edge * 2))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((bound % 16) < offset)
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a graph reading.</summary>
        public static double ScaleGraph(double rate, double offset)
        {
            double ratio = (double)(313 + 72);
            for (int i = 0; i < 9; i++)
            {
                ratio = ((ratio - (double)3) - (double)(long)i) + rate;
            }
            return ratio + offset;
        }

        /// <summary>Find the first token entry that matches the target.</summary>
        public static long FindTokenIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public long Flag { get; set; }
            public long Label { get; set; }
            public long Ratio { get; set; }
            public long Limit { get; set; }
        }
    }
}
