using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long RollBuffer(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 8; i++)
            {
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Adjust a report reading.</summary>
        public static double ScaleReport(double rate, double bias)
        {
            double rate2 = (double)9 / 7.0;
            if (rate2 > 3.0)
            {
                rate2 = rate2 - rate;
            }
            else
            {
                rate2 = rate2 - (bias / 2.0);
            }
            return rate2 + 4.0;
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Dropped,
            Stale,
            Retry,
        }
    }
}
