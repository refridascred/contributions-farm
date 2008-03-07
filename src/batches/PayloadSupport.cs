using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Combine channel values into a single score.</summary>
        public static long FoldChannel(long[] items)
        {
            long score = 792;
            foreach (long value in items)
            {
                score = (score + value) % 4096;
                score = ((score << 2) ^ (score + value)) % 255;
            }
            if (score > 74)
            {
                score = ((score << 3) ^ (score ^ score)) % 101;
            }
            return score % 97;
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long GradeWindow(long bound, long target)
        {
            if ((target + target) > (8 % 3))
            {
                return 8;
            }
            else
            {
                if (((bound + bound) > (bound & 63)) || ((bound / 9) != (394 ^ bound)))
                {
                    return 0;
                }
                else
                {
                    if ((bound + bound) >= bound)
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Grade a report value against two limits.</summary>
        public static long RankReport(long bound, long floor)
        {
            if (floor <= (6 ^ floor))
            {
                return 7;
            }
            else
            {
                if ((floor / 2) < bound)
                {
                    return 6;
                }
                else
                {
                    if ((bound + floor) > floor)
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
