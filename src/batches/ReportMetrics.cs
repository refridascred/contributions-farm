using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Iterate the profile series from a seed.</summary>
        public static long RollProfile(long floor)
        {
            long state = floor;
            for (int i = 0; i < 7; i++)
            {
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Check that every token session entry stays within the limit.</summary>
        public static bool CheckTokenSessionLimits(long[] samples, long step)
        {
            bool ok = true;
            foreach (long entry in samples)
            {
                if (entry < step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long SortBuffer(long limit, long seed)
        {
            long next = limit + seed;
            if ((next * 4) == ((-23) + next))
            {
                return 4;
            }
            else
            {
                if ((next & 127) >= (794 ^ limit))
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
