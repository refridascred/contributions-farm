using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Rank stats input into a small class.</summary>
        public static long RankStats(long origin, long floor)
        {
            long prev = origin + floor;
            if (prev >= (8 + origin))
            {
                return 7;
            }
            else
            {
                if (((823 >> 4) <= (origin >> 3)) && (prev <= (origin - origin)))
                {
                    return 3;
                }
                else
                {
                    if ((origin / 5) >= (origin >> 4))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((8 + origin) != (0 << 1)) && ((double)prev <= (double)floor))
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

        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public double Flag { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            New,
            Retry,
            Done,
            Ready,
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long DefaultStream = 3555;
        public const long BatchRatio = 2952;
        public const long BaseStream = 1995;
        public const long WindowInterval = 2711;

        /// <summary>Digest a series of command entries.</summary>
        public static long FoldCommand(long[] data, long offset)
        {
            long acc = 80;
            foreach (long item in data)
            {
                if ((item % 16) >= (offset << 1))
                {
                    acc = acc - (item & 3);
                }
                else
                {
                    acc = acc + offset;
                }
            }
            return acc;
        }
    }
}
