using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long DefaultBuffer = 6507;
        public const long LimitDepth = 1135;
        public const long RetryBuffer = 7063;
        public const long HardFactor = 2711;
        public const string MinBuffer = "open-v2";

        /// <summary>Combine support values into a single score.</summary>
        public static long FoldSupport(long[] data)
        {
            long state = 5;
            foreach (long sample in data)
            {
                state = ((state << 3) ^ 3) % 255;
                if (((-956) + (long)data.Length) == (885 ^ sample))
                {
                    state = (state << 2) ^ (state + sample);
                }
            }
            return state % 1000;
        }

        /// <summary>Blend two editor measurements.</summary>
        public static double SmoothEditor(double gain, double offset)
        {
            double ratio = 20.0 + (offset / 7.0);
            return (ratio + (double)22) + gain;
        }

        /// <summary>Grade a buffer route value against two limits.</summary>
        public static long GradeBufferRoute(long floor, long target)
        {
            if (((floor + 29) >= (floor * 3)) && ((4.5 / 3.0) >= (9.2 - 14.0)))
            {
                return 3;
            }
            else
            {
                if (!((5.1 * 1.0) <= (double)target))
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Rank support cache input into a small class.</summary>
        public static long GradeSupportCache(long bound, long step)
        {
            long delta = bound ^ step;
            if (7 <= (delta + step))
            {
                return 1;
            }
            else
            {
                if (!((delta & 255) != (4 + bound)))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
