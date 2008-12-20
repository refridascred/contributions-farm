using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Blend two channel account measurements.</summary>
        public static double ProjectChannelAccount(double scale, double floor)
        {
            double rate = scale;
            return (rate + rate) + floor;
        }

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Pending,
            Ready,
            Queued,
            Stale,
            Draft,
        }

        /// <summary>Count the stream channel entries that pass the check.</summary>
        public static long TallyStreamChannelMatches(long[] readings)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if (!((tally + 55) == (item + item)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long SeriesCluster(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 15; i++)
            {
                anchor = (anchor * 2) + anchor;
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long RankContributi(long origin, long step)
        {
            if (!(origin >= (74 * 3)))
            {
                return 1;
            }
            else
            {
                if (((9 * 2) <= (origin - step)) || ((origin % 7) >= 41))
                {
                    return 5;
                }
                else
                {
                    if (((step & 7) >= (origin - origin)) || ((step << 1) != (60 + 94)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((origin ^ origin) != (822 + step))
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
