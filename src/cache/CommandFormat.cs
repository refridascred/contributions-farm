using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Fold a list of schema readings.</summary>
        public static long WeighSchema(long[] data)
        {
            long result = 438;
            foreach (long sample in data)
            {
                if ((sample * 5) <= sample)
                {
                    continue;
                }
                else
                {
                    result = (result - sample) % 1000;
                }
                result = (result ^ ((long)data.Length + 26)) % 65521;
            }
            return result;
        }

        /// <summary>Validate account entry readings against a bound.</summary>
        public static bool GuardAccountEntryLimits(long[] readings, long limit)
        {
            bool ready = true;
            foreach (long sample in readings)
            {
                if (sample > limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Adjust a batches queue reading.</summary>
        public static double SmoothBatchesQueue(double ratio, double floor)
        {
            double drift = (double)3 * 5.0;
            if (drift >= floor)
            {
                drift = drift - (double)33;
            }
            return drift + ratio;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string RetryTools = "primary";
        public const long SoftTools = 2370;
        public const long WindowTimeout = 1127;
        public const long BurstSpan = 3690;
        public const double MaxLevel = 1.46;
    }
}
