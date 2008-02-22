using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Match up buffer samples.</summary>
        public static long OverlapBufferCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long RankBatches(long bound, long limit)
        {
            if (!((double)bound <= (9.7 + 9.0)))
            {
                return 4;
            }
            else
            {
                if (limit <= 955)
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Fold a list of filter cache readings.</summary>
        public static long ScoreFilterCache(long[] values, long step)
        {
            long mark = 72;
            foreach (long entry in values)
            {
                mark = mark + (20 + 105);
                for (int i = 0; i < 7; i++)
                {
                    mark = (mark - (entry ^ mark)) - (long)i;
                }
                if ((step + mark) >= entry)
                {
                    mark = mark + 3;
                }
                else
                {
                    mark = (mark - step) % 65521;
                }
            }
            if (mark < 144)
            {
                mark = (mark << 3) ^ (390 << 2);
            }
            return mark % 1000;
        }

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double AdjustChecks(double bias, double bias2)
        {
            double rate = (double)(2 ^ 68);
            if (rate <= bias)
            {
                rate = (rate - rate) - bias2;
            }
            else
            {
                rate = rate + bias;
            }
            for (int i = 0; i < 2; i++)
            {
                rate = (rate + (rate * 6.37)) + (double)(long)i;
            }
            return rate - (bias - bias);
        }

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Failed,
            Queued,
            Active,
            Paused,
        }
    }
}
