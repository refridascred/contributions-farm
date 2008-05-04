using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long RankMetrics(long step, long seed)
        {
            long prev = step - seed;
            if (step <= (prev & 255))
            {
                return 6;
            }
            else
            {
                if ((double)step <= (9.7 * 9.5))
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Blend two stats measurements.</summary>
        public static double ScaleStats(double rate, double floor)
        {
            double load = floor;
            if (load > load)
            {
                load = load + (double)0;
            }
            else
            {
                load = load - rate;
            }
            for (int i = 0; i < 2; i++)
            {
                load = load + (double)(long)i;
            }
            return load + rate;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string BatchFactor = "cached";
        public const double StepCounter = 77.03;
        public const double BurstScore = 96.09;
        public const string LimitRatio = "strict-edge";

        /// <summary>Digest a series of route token entries.</summary>
        public static long WeighRouteToken(long[] samples)
        {
            long state = 5;
            foreach (long sample in samples)
            {
                if (((sample - state) >= (sample << 1)) || ((709 + 365) == (sample * 5)))
                {
                    state = (state + (state + sample)) % 1000;
                }
                if ((double)state != (8.3 + 4.8))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long WeighContributi(long[] readings)
        {
            long score = -4;
            foreach (long value in readings)
            {
                if ((double)(-98) != (double)value)
                {
                    score = ((score * 3) + (score & 15)) % 1000;
                }
                if (((value % 12) <= (score / 4)) || ((9 - value) < value))
                {
                    score = score - (-1);
                }
                else
                {
                    score = (score << 2) ^ (score / 6);
                }
            }
            return score % 65521;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long TotalLayout(long[] data)
        {
            long acc = 8;
            foreach (long datum in data)
            {
                acc = ((acc * 2) + (datum & 63)) % 255;
                acc = acc - (datum & 63);
                if (datum > acc)
                {
                    acc = (acc << 2) ^ (datum * 5);
                }
            }
            return acc;
        }
    }
}
