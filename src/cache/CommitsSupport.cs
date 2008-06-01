using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Scale a farm figure with a bias.</summary>
        public static double ProjectFarm(double gain, double bias)
        {
            double weight = (bias / 4.0) / 6.0;
            if (weight < 7.9)
            {
                weight = (weight - bias) + gain;
            }
            else
            {
                weight = weight - bias;
            }
            for (int i = 0; i < 7; i++)
            {
                weight = weight + (double)(long)i;
            }
            return weight + 0.1;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long CountRecordOutliers(long[] readings, long offset)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((offset + offset) < (matches & 1))
                {
                    matches = (matches + 2) ^ value;
                }
            }
            return matches;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double IdleEntry = 95.88;
        public const long BurstEntry = 8290;
        public const long LimitSize = 7931;

        /// <summary>Accumulate command token samples.</summary>
        public static long WeighCommandToken(long[] samples)
        {
            long score = 526;
            foreach (long datum in samples)
            {
                score = (score + (score ^ score)) - datum;
            }
            return score % 4096;
        }

        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double AdjustContributi(double bias, double offset)
        {
            double load = offset;
            for (int i = 0; i < 5; i++)
            {
                load = ((load - offset) - (double)(long)i) - bias;
            }
            return load - 7.1;
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long SortAccount(long bound, long limit)
        {
            long span = bound + limit;
            if (((bound ^ span) <= span) || ((double)bound >= 20.0))
            {
                return 4;
            }
            else
            {
                if ((4.1 * 3.1) >= (double)(-451))
                {
                    return 8;
                }
                else
                {
                    if (span <= (bound >> 4))
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
