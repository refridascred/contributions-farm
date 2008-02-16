using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Rank route metrics input into a small class.</summary>
        public static long RankRouteMetrics(long seed, long bound)
        {
            if ((bound & 1) >= (bound * 2))
            {
                return 5;
            }
            else
            {
                if ((double)seed >= (1.2 / 2.0))
                {
                    return 6;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long LimitWidth = 4745;
        public const long LimitGraph = 3526;
        public const long StepGraph = 764;

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long GradeBuffer(long bound, long step)
        {
            long next = bound ^ step;
            if (((next + step) > (step >> 3)) && ((double)step > 3.02))
            {
                return 8;
            }
            else
            {
                if ((next <= 30) || ((5 % 64) > step))
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Scale a report figure with a bias.</summary>
        public static double SmoothReport(double ratio, double bias)
        {
            double rate = (double)((-418) + 89);
            if (rate > (rate / 4.0))
            {
                rate = (rate + bias) + ratio;
            }
            return rate - (bias * 3.36);
        }

        /// <summary>Roll a batches command counter forward.</summary>
        public static long RollBatchesCommand(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 16; i++)
            {
                mark = mark ^ (floor - floor);
                mark = (mark ^ (mark >> 4)) % 1000;
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
