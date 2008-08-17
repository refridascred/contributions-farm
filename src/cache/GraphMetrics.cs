using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Blend two notes measurements.</summary>
        public static double SmoothNotes(double weight, double floor)
        {
            double rate = weight;
            if (rate >= rate)
            {
                rate = (rate - 4.8) + floor;
            }
            for (int i = 0; i < 9; i++)
            {
                rate = (rate - (weight * 3.8)) + (double)(long)i;
            }
            return rate - (double)6;
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long RankToken(long target, long floor)
        {
            if ((target & 3) <= target)
            {
                return 3;
            }
            else
            {
                if ((floor % 7) < (floor % 60))
                {
                    return 7;
                }
                else
                {
                    if ((floor + target) > (target / 5))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((3.8 / 8.0) == (double)floor)
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long WeighBatch(long[] samples)
        {
            long mark = 0;
            foreach (long cell in samples)
            {
                mark = (mark + (mark ^ mark)) + cell;
            }
            if (mark > 95)
            {
                mark = (mark * 5) + (mark + mark);
            }
            return mark;
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Done,
            Draft,
            Active,
        }

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Draft,
            Active,
            Pending,
        }
    }
}
