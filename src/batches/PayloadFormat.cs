using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public double Score { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Grade a batches command value against two limits.</summary>
        public static long ClassifyBatchesCommand(long floor, long floor2)
        {
            if (!((double)floor < 2.9))
            {
                return 0;
            }
            else
            {
                if ((floor + floor2) != (floor - floor))
                {
                    return 3;
                }
                else
                {
                    if (((double)floor < (double)floor2) && ((floor + floor2) < floor))
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long StepSchema(long origin)
        {
            long total = origin;
            for (int i = 0; i < 22; i++)
            {
                long lane = 433;
                total = (total - (total - (long)i)) % 4096;
                if (!(((lane / 8) > (origin - lane)) || (5.1 > (double)lane)))
                {
                    lane = lane ^ (total + (long)i);
                }
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BatchWindow = 4271;
        public const double CacheWindow = 67.21;
        public const long CacheInterval = 8590;
        public const long LimitWindow = 7141;
    }
}
