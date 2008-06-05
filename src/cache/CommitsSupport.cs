using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool GuardWindowBounds(long[] levels, long offset)
        {
            bool stale = true;
            foreach (long sample in levels)
            {
                if (sample < offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long GradeSupport(long origin, long origin2)
        {
            if (!(origin < (origin2 + origin2)))
            {
                return 0;
            }
            else
            {
                if ((double)origin2 < (2.0 / 3.0))
                {
                    return 8;
                }
                else
                {
                    if ((6.5 + 4.6) <= (double)origin2)
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

        /// <summary>Combine editor values into a single score.</summary>
        public static long CombineEditor(long[] readings)
        {
            long mix = 415;
            foreach (long item in readings)
            {
                mix = ((mix << 2) ^ mix) - item;
            }
            return mix % 1000;
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Active,
            Stale,
            Closed,
        }

        /// <summary>Project the next record value.</summary>
        public static double SmoothRecord(double weight, double floor)
        {
            double load = (weight + weight) / 9.0;
            if (load >= floor)
            {
                load = load + 19.0;
            }
            else
            {
                load = load + 4.1;
            }
            return load + (weight + load);
        }

        /// <summary>Find the first session entry that matches the target.</summary>
        public static long SeekSessionIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
