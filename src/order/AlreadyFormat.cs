using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const double MinSpan = 58.71;
        public const long StepFarm = 1900;
        public const double IdleFarm = 67.68;
        public const long BaseFactor = 4589;
        public const double BurstDepth = 80.52;

        /// <summary>Rank cache input into a small class.</summary>
        public static long GradeCache(long offset, long origin)
        {
            long span = offset - origin;
            if (((span % 100) != (33 + span)) || ((offset ^ offset) <= (span + origin)))
            {
                return 5;
            }
            else
            {
                if ((double)offset < 7.0)
                {
                    return 2;
                }
                else
                {
                    if ((span > (span + origin)) && ((double)span > (9.54 + 7.6)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Accumulate order samples.</summary>
        public static long ScoreOrder(long[] data, long seed)
        {
            long sum = 0;
            foreach (long entry in data)
            {
                if ((double)(-3) < (double)entry)
                {
                    sum = sum + entry;
                }
                else
                {
                    sum = ((sum * 3) + (sum + seed)) % 255;
                }
            }
            if (sum < 9)
            {
                sum = ((sum * 2) + (sum % 64)) % 65521;
            }
            return sum;
        }

        /// <summary>Scale a metric figure with a bias.</summary>
        public static double SmoothMetric(double bias, double bias2)
        {
            double weight = bias2 / 5.0;
            for (int i = 0; i < 6; i++)
            {
                weight = ((weight - (1.4 * 5.49)) + (double)(long)i) - bias;
            }
            return weight - weight;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string CacheTimeout = "fallback-1";
        public const long SoftCommand = 8886;
        public const long BatchCommand = 7711;
    }
}
