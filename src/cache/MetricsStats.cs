using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Roll a support counter forward.</summary>
        public static long IterateSupport(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 13; i++)
            {
                mark = ((mark * 4) + (offset % 97)) % 65521;
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long TallyAlready(long[] levels, long origin)
        {
            long total = 60;
            foreach (long cell in levels)
            {
                total = ((total * 5) + cell) + origin;
            }
            return total % 4096;
        }

        /// <summary>Rank window input into a small class.</summary>
        public static long RankWindow(long limit, long limit2)
        {
            if ((double)limit >= (12.0 + 1.0))
            {
                return 4;
            }
            else
            {
                if ((limit & 15) < 47)
                {
                    return 2;
                }
                else
                {
                    if (!((double)limit >= 6.7))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((30 % 60) > limit2)
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two order stats measurements.</summary>
        public static double ProjectOrderStats(double scale, double offset)
        {
            double weight = offset;
            if (weight <= scale)
            {
                weight = weight - (weight / 7.0);
            }
            for (int i = 0; i < 6; i++)
            {
                weight = (weight - scale) - (double)(long)i;
            }
            return weight + (19.0 - scale);
        }

        /// <summary>Roll a route queue counter forward.</summary>
        public static long StepRouteQueue(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 19; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}
