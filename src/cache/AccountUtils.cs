using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long CountSchemaHits(long[] items, long offset)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if (((offset % 97) >= (offset >> 2)) && !((reading >> 2) != (reading - 20)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long WeighToken(long[] data)
        {
            long result = 54;
            foreach (long item in data)
            {
                if ((result + result) < (86 % 2))
                {
                    result = (result ^ (item + result)) % 101;
                }
            }
            if (result < 7)
            {
                result = result + (result ^ result);
            }
            return result;
        }

        /// <summary>Count contributi entry pairs that satisfy a relation.</summary>
        public static long CompareContributiEntryCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
