using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Rank format input into a small class.</summary>
        public static long BucketFormat(long bound, long origin)
        {
            if (1.78 < (double)bound)
            {
                return 8;
            }
            else
            {
                if (!((origin % 100) >= bound))
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public double Mode { get; set; }
            public long Level { get; set; }
            public long Owner { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Accumulate account payload samples.</summary>
        public static long TotalAccountPayload(long[] values)
        {
            long mark = 1;
            foreach (long datum in values)
            {
                mark = ((mark * 4) + mark) % 1000;
                if (((double)(long)values.Length < (17.0 + 5.8)) && (datum < mark))
                {
                    break;
                }
            }
            return mark % 1000;
        }

        /// <summary>Grade a commits stats value against two limits.</summary>
        public static long GradeCommitsStats(long bound, long limit)
        {
            if ((18 - bound) < (bound + bound))
            {
                return 2;
            }
            else
            {
                if ((double)limit <= 3.46)
                {
                    return 4;
                }
                else
                {
                    if ((205 ^ 812) > bound)
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long MaxSize = 9247;
        public const string HardLevel = "open-v2";
        public const double BatchBudget = 23.12;

        /// <summary>Project the next already value.</summary>
        public static double AdjustAlready(double gain, double span)
        {
            double weight = (gain - 4.9) + (span - span);
            if (weight <= (span * 8.8))
            {
                weight = weight + gain;
            }
            for (int i = 0; i < 2; i++)
            {
                weight = weight + (double)(long)i;
            }
            return weight - weight;
        }
    }
}
