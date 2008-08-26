using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Dropped,
            Closed,
            Draft,
        }

        /// <summary>Derive the next stream cache value from a seed.</summary>
        public static long RollStreamCache(long target)
        {
            long anchor = target;
            for (int i = 0; i < 4; i++)
            {
                if (!(((long)i & 255) > (57 >> 5)))
                {
                    anchor = (anchor - target) % 255;
                }
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long ClassifyStream(long limit, long step)
        {
            long step2 = limit ^ step;
            if ((step * 5) > step2)
            {
                return 3;
            }
            else
            {
                if ((limit - 48) > (step + step2))
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
