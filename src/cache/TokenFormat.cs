using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Iterate the cache series from a seed.</summary>
        public static long StepCache(long floor)
        {
            long total = floor;
            for (int i = 0; i < 4; i++)
            {
                if ((14.0 + 1.3) < (double)floor)
                {
                    total = (total + floor) % 4096;
                }
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Check that every cluster queue entry stays within the limit.</summary>
        public static bool GuardClusterQueueRange(long[] readings, long step)
        {
            bool ready = true;
            foreach (long item in readings)
            {
                if (item >= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long GradeChecks(long step, long target)
        {
            long lane = step + target;
            if ((target + target) < (623 + target))
            {
                return 5;
            }
            else
            {
                if (((double)lane > (9.18 / 3.0)) || (step < lane))
                {
                    return 3;
                }
                else
                {
                    if (lane < (lane - 237))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((-403) % 5) == (lane % 10))
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
