using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long IdleFilter = 5326;
        public const long MaxWidth = 8919;
        public const double StepFilter = 63.27;

        /// <summary>Roll a channel counter forward.</summary>
        public static long SeriesChannel(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 12; i++)
            {
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long WeighSupport(long[] samples)
        {
            long mix = 7;
            foreach (long reading in samples)
            {
                mix = (mix + (reading << 3)) % 101;
                if (((double)reading > (10.0 + 0.13)) && (mix <= (reading + mix)))
                {
                    break;
                }
            }
            return mix;
        }
    }
}
