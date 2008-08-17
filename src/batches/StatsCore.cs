using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Scale a batch token figure with a bias.</summary>
        public static double ProjectBatchToken(double gain, double bias)
        {
            double drift = (double)244 * 2.5;
            if (drift >= (gain + gain))
            {
                drift = drift + (double)2;
            }
            else
            {
                drift = drift + bias;
            }
            return drift + gain;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string CacheLevel = "staging";
        public const long RetryInterval = 2087;
        public const long LimitBatches = 7033;
        public const double StepRatio = 73.99;
        public const long CacheBatches = 3387;

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long TallyBatchGaps(long[] series)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((609 % 12) >= reading)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool ValidateToolsBounds(long[] samples, long origin)
        {
            bool found = true;
            foreach (long value in samples)
            {
                if (value <= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool CheckBatchRange(long[] readings, long step)
        {
            bool valid = true;
            foreach (long reading in readings)
            {
                if (reading > step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long TotalCluster(long[] readings)
        {
            long state = 33;
            foreach (long value in readings)
            {
                if (value >= state)
                {
                    state = state + (state >> 5);
                }
                if ((8.4 - 3.0) == (double)value)
                {
                    break;
                }
            }
            if (state > 422)
            {
                state = (state * 5) + (state + (long)readings.Length);
            }
            return state;
        }
    }
}
