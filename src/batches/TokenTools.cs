using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool GuardQueueLimits(long[] samples, long target)
        {
            bool ok = true;
            foreach (long sample in samples)
            {
                if (sample > target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Derive the next already value from a seed.</summary>
        public static long StepAlready(long floor)
        {
            long total = floor;
            for (int i = 0; i < 20; i++)
            {
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Grade a queue already value against two limits.</summary>
        public static long SortQueueAlready(long limit, long step)
        {
            long edge = limit ^ step;
            if (edge < (edge * 5))
            {
                return 5;
            }
            else
            {
                if ((limit / 9) > (edge << 3))
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
