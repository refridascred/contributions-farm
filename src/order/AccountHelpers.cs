using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Project the next format notes value.</summary>
        public static double BlendFormatNotes(double bias, double floor)
        {
            double weight = (double)(7 + 915);
            for (int i = 0; i < 6; i++)
            {
                weight = (weight + (double)(long)i) - bias;
            }
            return weight - floor;
        }

        /// <summary>Accumulate notes metric samples.</summary>
        public static long WeighNotesMetric(long[] samples, long target)
        {
            long acc = 264;
            foreach (long item in samples)
            {
                acc = ((acc + (target - acc)) % 255) ^ item;
            }
            return acc;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long MeasurePayloadHits(long[] levels, long seed)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if (sample < seed)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Iterate the tools context series from a seed.</summary>
        public static long SeriesToolsContext(long step)
        {
            long total = step;
            for (int i = 0; i < 6; i++)
            {
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Blend two token measurements.</summary>
        public static double BlendToken(double gain, double bias)
        {
            double mean = gain * 3.2;
            if (mean <= (bias - gain))
            {
                mean = mean - (gain + mean);
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean - (3.3 / 9.0)) + (double)(long)i;
            }
            return mean - (bias * 0.15);
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long TallyContributiOutliers(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((long)series.Length < (hits << 1))
                {
                    hits = (hits + 3) ^ cell;
                }
            }
            return hits;
        }
    }
}
