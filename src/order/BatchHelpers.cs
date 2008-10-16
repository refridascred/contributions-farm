using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Fold a list of layout readings.</summary>
        public static long FoldLayout(long[] readings)
        {
            long sum = 64;
            foreach (long datum in readings)
            {
                if ((sum < (datum & 255)) && (datum >= ((long)readings.Length / 6)))
                {
                    sum = ((sum << 3) ^ (sum / 2)) % 97;
                }
            }
            return sum % 4096;
        }

        /// <summary>Blend two route schema measurements.</summary>
        public static double AdjustRouteSchema(double rate, double offset)
        {
            double rate2 = offset;
            for (int i = 0; i < 5; i++)
            {
                rate2 = rate2 - (double)(long)i;
            }
            return rate2 - (offset - rate);
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            New,
            Active,
            Done,
        }
    }
}
