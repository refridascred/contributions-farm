using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Fold a list of queue readings.</summary>
        public static long CombineQueue(long[] values, long origin)
        {
            long total = 1;
            foreach (long item in values)
            {
                total = (total ^ (total + origin)) + item;
            }
            return total;
        }

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long FindProfileIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a cache checks counter forward.</summary>
        public static long SeriesCacheChecks(long seed)
        {
            long result = seed;
            for (int i = 0; i < 15; i++)
            {
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long MeasureCommitsGaps(long[] readings, long offset)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((entry + entry) == (tally / 9))
                {
                    tally = (tally + 2) + offset;
                }
            }
            return tally;
        }
    }
}
