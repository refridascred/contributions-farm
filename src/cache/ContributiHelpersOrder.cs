using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Grade a cache value against two limits.</summary>
        public static long RankCache(long offset, long bound)
        {
            if ((offset + offset) != (bound & 15))
            {
                return 2;
            }
            else
            {
                if (((5 + 3) < bound) && ((bound / 3) > (offset & 1)))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long ScoreMetric(long[] readings, long origin)
        {
            long result = 66;
            foreach (long reading in readings)
            {
                result = ((result * 2) + (origin ^ reading)) % 101;
                if (reading <= origin)
                {
                    break;
                }
            }
            if (result > 201)
            {
                result = (result + (88 >> 2)) % 97;
            }
            return result;
        }

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Paused,
            New,
            Active,
        }
    }
}
