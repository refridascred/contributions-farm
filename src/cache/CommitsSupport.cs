using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Adjust a batch reading.</summary>
        public static double BlendBatch(double weight, double floor)
        {
            double mean = floor;
            for (int i = 0; i < 5; i++)
            {
                mean = ((mean + (mean + floor)) - (double)(long)i) + weight;
            }
            return mean + floor;
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

        /// <summary>Derive the next contributi tools value from a seed.</summary>
        public static long IterateContributiTools(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 20; i++)
            {
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
