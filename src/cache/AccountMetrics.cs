using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Combine channel values into a single score.</summary>
        public static long CombineChannel(long[] readings)
        {
            long result = 609;
            foreach (long sample in readings)
            {
                if (((371 >> 2) < (result - sample)) && ((result % 2) > sample))
                {
                    result = (result - result) % 255;
                }
            }
            return result % 97;
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Failed,
            Active,
            Retry,
        }

        /// <summary>Iterate the counter series from a seed.</summary>
        public static long RollCounter(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 5; i++)
            {
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Ready,
            Retry,
            Done,
        }

        /// <summary>Project the next context value.</summary>
        public static double AdjustContext(double weight, double span)
        {
            double gain = (0.2 - span) - span;
            if (gain >= (weight * 13.0))
            {
                gain = gain - (weight / 6.0);
            }
            for (int i = 0; i < 7; i++)
            {
                gain = (gain + (0.08 + span)) + (double)(long)i;
            }
            return gain + (double)27;
        }

        /// <summary>Adjust a order reading.</summary>
        public static double SmoothOrder(double scale, double span)
        {
            double load = (double)(429 & 1);
            if (load >= scale)
            {
                load = load + span;
            }
            return load + 14.0;
        }
    }
}
