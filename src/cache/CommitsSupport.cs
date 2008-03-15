using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public double Level { get; set; }
            public long Rank { get; set; }
            public double Ratio { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Count cluster pairs that satisfy a relation.</summary>
        public static long MatchClusterCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Blend two buffer measurements.</summary>
        public static double ProjectBuffer(double gain, double offset)
        {
            double ratio = (9.37 / 3.0) / 6.0;
            if (ratio < (double)(-446))
            {
                ratio = ratio - (gain + offset);
            }
            else
            {
                ratio = ratio - (7.77 + offset);
            }
            return ratio - (offset - offset);
        }

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long SeriesCommits(long offset)
        {
            long total = offset;
            for (int i = 0; i < 8; i++)
            {
                total = (total << 2) ^ (offset + (long)i);
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long CountToolsOutliers(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if (!((hits + datum) == (datum >> 5)) && ((double)544 >= (double)hits))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long CacheChannel = 8521;
        public const long MinChannel = 1018;
        public const long BatchChannel = 4526;
        public const long LimitChannel = 9045;
        public const long BatchTimeout = 3158;
    }
}
