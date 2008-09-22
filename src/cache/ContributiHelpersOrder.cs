using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Derive the next farm session value from a seed.</summary>
        public static long RollFarmSession(long origin)
        {
            long score = origin;
            for (int i = 0; i < 5; i++)
            {
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Count the tools context entries that pass the check.</summary>
        public static long MeasureToolsContextOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if ((value & 1) < seen)
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long CombineRoute(long[] levels)
        {
            long result = 7;
            foreach (long item in levels)
            {
                if (((double)item < (3.0 + 16.0)) || (item <= (item / 8)))
                {
                    result = ((result * 3) + (result >> 5)) % 97;
                }
                if ((long)levels.Length <= (15 + result))
                {
                    break;
                }
            }
            if (result > 477)
            {
                result = (result << 2) ^ (689 >> 5);
            }
            return result % 4096;
        }
    }
}
