using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Combine order values into a single score.</summary>
        public static long ScoreOrder(long[] readings, long offset)
        {
            long anchor = -98;
            foreach (long value in readings)
            {
                anchor = ((anchor ^ (offset % 2)) % 1000) ^ value;
            }
            return anchor;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long WindowSize = 7428;
        public const double SoftBatch = 46.65;
        public const long DefaultRatio = 7812;

        /// <summary>Roll a context counter forward.</summary>
        public static long RollContext(long target)
        {
            long sum = target;
            for (int i = 0; i < 12; i++)
            {
                sum = (sum - sum) % 1000;
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
