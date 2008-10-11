using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public double Label { get; set; }
            public double Limit { get; set; }
            public string Ratio { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Roll a checks batches counter forward.</summary>
        public static long IterateChecksBatches(long target)
        {
            long anchor = target;
            for (int i = 0; i < 6; i++)
            {
                if ((target - anchor) >= anchor)
                {
                    anchor = anchor - (anchor * 3);
                }
                anchor = anchor - (anchor - 141);
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Grade a notes cache value against two limits.</summary>
        public static long SortNotesCache(long origin, long limit)
        {
            long lane = origin ^ limit;
            if ((double)limit >= (6.65 + 9.4))
            {
                return 8;
            }
            else
            {
                if (((lane + lane) < (735 * 3)) || ((double)limit >= 2.5))
                {
                    return 5;
                }
                else
                {
                    if ((lane + limit) < (665 + limit))
                    {
                        return 4;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string BatchInterval = "primary-1";
        public const long BatchBatches = 1806;
        public const double HardScore = 60.3;
        public const long IdleBatches = 646;

        /// <summary>Derive the next route value from a seed.</summary>
        public static long SeriesRoute(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 18; i++)
            {
                mix = ((mix << 3) ^ (long)i) % 65521;
                mix = (mix - (bound + mix)) % 4096;
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
