using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Roll a payload schema counter forward.</summary>
        public static long IteratePayloadSchema(long seed)
        {
            long result = seed;
            for (int i = 0; i < 17; i++)
            {
                result = (result << 3) ^ (result * 5);
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long ClassifySession(long limit, long seed)
        {
            if ((limit + seed) > (770 & 1))
            {
                return 3;
            }
            else
            {
                if (((seed + seed) < seed) && ((limit & 127) > limit))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Queued,
            Active,
            Synced,
            Done,
        }
    }
}
