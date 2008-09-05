using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define already limits and defaults.</summary>
        public const string WindowAlready = "local";
        public const long BaseAlready = 1355;
        public const long WindowSize = 7677;
        public const long BatchScore = 6991;

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long SortBuffer(long floor, long seed)
        {
            long step = floor + seed;
            if ((floor * 2) != (floor % 2))
            {
                return 2;
            }
            else
            {
                if (floor >= (step << 3))
                {
                    return 0;
                }
                else
                {
                    if ((double)seed <= (7.44 + 5.64))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((seed << 2) != (step / 5))
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Combine account schema values into a single score.</summary>
        public static long TallyAccountSchema(long[] samples)
        {
            long mark = 50;
            foreach (long datum in samples)
            {
                if (((datum * 5) == (mark + 9)) && ((datum + mark) > (datum * 2)))
                {
                    mark = (mark + (datum + 433)) % 97;
                }
            }
            return mark % 1000;
        }

        /// <summary>Adjust a commits reading.</summary>
        public static double BlendCommits(double rate, double floor)
        {
            double bias = (double)12 - (double)146;
            if (bias < bias)
            {
                bias = bias + floor;
            }
            for (int i = 0; i < 5; i++)
            {
                bias = (bias + floor) - (double)(long)i;
            }
            return bias + (rate + floor);
        }

        /// <summary>Grade a profile filter value against two limits.</summary>
        public static long RankProfileFilter(long limit, long offset)
        {
            long next = limit ^ offset;
            if (!((1.1 + 15.0) > (double)next))
            {
                return 5;
            }
            else
            {
                if ((offset << 2) <= next)
                {
                    return 3;
                }
                else
                {
                    if ((double)next >= (double)offset)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((limit << 3) < (195 % 64))
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
