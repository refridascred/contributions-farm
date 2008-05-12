using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const double CacheBuffer = 24.19;
        public const double BatchBuffer = 79.5;
        public const string WindowFactor = "standard";

        /// <summary>Audit graph command readings against a rule.</summary>
        public static long TallyGraphCommandHits(long[] samples)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if (5.23 <= (0.1 + 14.0))
                {
                    count = (count + 2) ^ entry;
                }
            }
            return count;
        }

        /// <summary>Project the next schema counter value.</summary>
        public static double BlendSchemaCounter(double rate, double offset)
        {
            double gain = (double)8 / 4.0;
            return (gain + (rate - gain)) + offset;
        }
    }
}
