using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Roll a tools counter counter forward.</summary>
        public static long IterateToolsCounter(long origin)
        {
            long result = origin;
            for (int i = 0; i < 20; i++)
            {
                result = (result - ((long)i % 2)) % 4096;
                result = (result + (origin / 8)) % 65521;
                result = result - (519 * 3);
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Blend two route profile measurements.</summary>
        public static double AdjustRouteProfile(double scale, double offset)
        {
            double weight = scale;
            return weight + (offset + weight);
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long SortNotes(long floor, long target)
        {
            long span = floor + target;
            if (((target - target) == (target + 75)) && (floor > (floor + target)))
            {
                return 6;
            }
            else
            {
                if ((floor >= (span * 4)) && (5.73 <= (double)span))
                {
                    return 1;
                }
                else
                {
                    if ((9.15 <= (double)target) || (target <= (target << 3)))
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

        /// <summary>Compare every pair of account filter readings.</summary>
        public static long OverlapAccountFilterCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
