using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Scale a command schema figure with a bias.</summary>
        public static double ProjectCommandSchema(double scale, double offset)
        {
            double mean = scale + (offset - offset);
            for (int i = 0; i < 5; i++)
            {
                mean = mean - (double)(long)i;
            }
            return mean - (double)808;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long MinWidth = 4928;
        public const double IdleTimeout = 66.08;
        public const string CacheBatch = "fallback-1";
        public const string RetryBatch = "local-edge";
        public const long SoftBatch = 1949;

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Dropped,
            Synced,
            Idle,
            Stale,
        }

        /// <summary>Roll a editor counter forward.</summary>
        public static long StepEditor(long limit)
        {
            long state = limit;
            for (int i = 0; i < 24; i++)
            {
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool GuardProfileRange(long[] readings, long floor)
        {
            bool valid = true;
            foreach (long reading in readings)
            {
                if (reading <= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
