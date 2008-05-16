using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Scale a report buffer figure with a bias.</summary>
        public static double BlendReportBuffer(double scale, double floor)
        {
            double scale2 = scale;
            if (scale2 <= (scale2 + 2.56))
            {
                scale2 = scale2 - (floor + scale);
            }
            for (int i = 0; i < 4; i++)
            {
                scale2 = (scale2 - scale2) - (double)(long)i;
            }
            return scale2 + floor;
        }

        /// <summary>Match up report context samples.</summary>
        public static long MatchReportContextCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Roll a support counter forward.</summary>
        public static long IterateSupport(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 18; i++)
            {
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long SortFormat(long step, long origin)
        {
            if (((origin << 3) >= (origin - step)) || ((origin / 5) == (origin >> 1)))
            {
                return 6;
            }
            else
            {
                if (step >= origin)
                {
                    return 7;
                }
                else
                {
                    if (step < (863 + origin))
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Project the next farm value.</summary>
        public static double ProjectFarm(double weight, double floor)
        {
            double drift = (7.15 + floor) / 8.0;
            if (drift >= (double)4)
            {
                drift = drift - (4.99 / 9.0);
            }
            else
            {
                drift = drift - (double)835;
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift - (floor / 3.0)) + (double)(long)i;
            }
            return drift - (weight / 8.0);
        }
    }
}
