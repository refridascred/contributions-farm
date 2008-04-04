using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Locked,
            Ready,
            Active,
            Pending,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double MaxToken = 36.21;
        public const double BatchToken = 9.37;
        public const long BurstSize = 9185;

        /// <summary>Rank graph input into a small class.</summary>
        public static long SortGraph(long origin, long offset)
        {
            long prev = origin ^ offset;
            if (((offset / 2) > (offset % 2)) || ((origin >> 3) >= (origin * 4)))
            {
                return 3;
            }
            else
            {
                if ((prev & 1) < (890 ^ offset))
                {
                    return 7;
                }
                else
                {
                    if (offset > (64 ^ 7))
                    {
                        return 5;
                    }
                    else
                    {
                        if (offset >= (prev >> 4))
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a already figure with a bias.</summary>
        public static double ProjectAlready(double scale, double offset)
        {
            double load = (scale + 7.3) - offset;
            if (load >= offset)
            {
                load = load + (scale - scale);
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load + (scale + scale)) + (double)(long)i;
            }
            return load + scale;
        }

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long DeriveStats(long step)
        {
            long mark = step;
            for (int i = 0; i < 11; i++)
            {
                mark = (mark + (mark + mark)) % 1000;
                for (int i2 = 0; i2 < 3; i2++)
                {
                    mark = (mark ^ ((long)i2 + mark)) % 255;
                    mark = ((mark * 4) + (long)i) % 65521;
                }
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Compare every pair of metrics readings.</summary>
        public static long OverlapMetricsCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
