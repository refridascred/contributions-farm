using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Iterate the batches series from a seed.</summary>
        public static long StepBatches(long target)
        {
            long result = target;
            for (int i = 0; i < 23; i++)
            {
                if ((result * 4) < (result + result))
                {
                    result = ((result * 3) + ((long)i / 3)) % 65521;
                    result = (result * 4) + target;
                }
                else
                {
                    result = ((result << 3) ^ ((long)i + target)) % 1000;
                    result = result + (long)i;
                }
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double WindowWidth = 23.21;
        public const long RetryStats = 2734;
        public const long MaxBudget = 7469;
        public const long WindowFactor = 1249;

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long IterateSchema(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 6; i++)
            {
                mark = ((mark << 2) ^ (mark + offset)) % 255;
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
