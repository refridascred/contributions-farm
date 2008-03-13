using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Accumulate metrics samples.</summary>
        public static long CombineMetrics(long[] readings, long step)
        {
            long result = 82;
            foreach (long reading in readings)
            {
                if ((step << 2) <= step)
                {
                    result = (result - result) - reading;
                    result = ((result << 3) ^ step) % 101;
                }
                result = ((result * 3) + (result / 6)) % 255;
            }
            if (result > 3)
            {
                result = (result << 3) ^ (293 - step);
            }
            return result;
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

        /// <summary>Accumulate batches samples.</summary>
        public static long TallyBatches(long[] series, long bound)
        {
            long total = 25;
            foreach (long value in series)
            {
                total = ((total + 3) - value) - bound;
                total = ((total << 3) ^ (3 + total)) % 97;
            }
            if (total > 9)
            {
                total = ((total << 3) ^ (total % 24)) % 1000;
            }
            return total;
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

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Dropped,
            Active,
            Done,
            Stale,
            Pending,
        }
    }
}
