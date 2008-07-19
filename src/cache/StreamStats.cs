using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Measure how many session format samples are out of range.</summary>
        public static long TallySessionFormatOutliers(long[] items, long origin)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if (origin <= (origin + seen))
                {
                    seen = (seen + 3) - item;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long GradeSession(long origin, long origin2)
        {
            long next = origin - origin2;
            if ((next << 1) >= 5)
            {
                return 5;
            }
            else
            {
                if ((351 ^ origin2) == (origin2 - origin2))
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Adjust a command reading.</summary>
        public static double ProjectCommand(double weight, double bias)
        {
            double weight2 = (bias - bias) + (double)7;
            if (weight2 > (bias * 0.36))
            {
                weight2 = (weight2 + bias) - weight;
            }
            else
            {
                weight2 = weight2 + (weight2 / 7.0);
            }
            return weight2 + 1.9;
        }

        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long SeekCounterIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= offset) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
