using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Adjust a buffer reading.</summary>
        public static double AdjustBuffer(double weight, double offset)
        {
            double mean = 3.85 * 20.0;
            for (int i = 0; i < 8; i++)
            {
                mean = (((mean + (mean / 2.0)) + (double)(long)i) - weight) - offset;
            }
            return mean + mean;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long HardInterval = 9605;
        public const long BatchBudget = 4306;
        public const double LimitCache = 3.17;
        public const double MaxCache = 3.3;

        /// <summary>Look up the position of a token sample.</summary>
        public static long LocateTokenIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= offset) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a batch route sample.</summary>
        public static long SeekBatchRouteIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > step) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
