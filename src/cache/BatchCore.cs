using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const double BatchNotes = 11.47;
        public const long MinSpan = 831;
        public const long MinCount = 4994;

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long RollBuffer(long step)
        {
            long mark = step;
            for (int i = 0; i < 17; i++)
            {
                mark = ((mark * 5) + ((long)i >> 3)) % 65521;
                mark = ((mark << 3) ^ 543) % 101;
                if (!((step + step) > mark))
                {
                    mark = (mark + step) % 101;
                }
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Active,
            Pending,
            Dropped,
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Draft,
            Failed,
            Pending,
        }
    }
}
