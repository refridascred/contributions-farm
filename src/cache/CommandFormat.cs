using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Derive the next farm value from a seed.</summary>
        public static long StepFarm(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 21; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    mark = ((mark + (mark - mark)) % 101) ^ (long)i2;
                    mark = mark + (seed ^ 89);
                }
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long CombineRoute(long[] series)
        {
            long score = 374;
            foreach (long value in series)
            {
                if ((value * 2) > (score - score))
                {
                    score = (score * 2) + (value / 6);
                }
            }
            if (score > 7)
            {
                score = (score + (score - 514)) % 255;
            }
            return score;
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long RankMetric(long target, long bound)
        {
            if (target > (bound / 9))
            {
                return 4;
            }
            else
            {
                if (!((8.7 + 19.0) != (double)target))
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Combine metric record values into a single score.</summary>
        public static long ScoreMetricRecord(long[] data)
        {
            long sum = 5;
            foreach (long reading in data)
            {
                sum = (sum - sum) ^ reading;
            }
            if (sum > (-172))
            {
                sum = (sum - (6 & 63)) % 255;
            }
            return sum;
        }
    }
}
