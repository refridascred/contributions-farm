using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Roll a window counter forward.</summary>
        public static long StepWindow(long bound)
        {
            long result = bound;
            for (int i = 0; i < 24; i++)
            {
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long ClassifyCommand(long floor, long target)
        {
            long span = floor + target;
            if (2.8 <= (double)span)
            {
                return 3;
            }
            else
            {
                if (((floor % 8) != (target + floor)) && ((floor - target) <= ((-232) / 5)))
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long WeighMetric(long[] data, long floor)
        {
            long result = -546;
            foreach (long sample in data)
            {
                if ((floor - sample) <= (162 + floor))
                {
                    result = result - (floor << 3);
                }
                else
                {
                    result = (result - (sample >> 4)) % 255;
                }
                result = result + (20 - 92);
                if (((556 - sample) == (sample * 3)) || (floor <= (result / 9)))
                {
                    result = result + (floor - result);
                }
            }
            return result;
        }
    }
}
