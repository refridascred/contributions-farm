using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long CountBufferGaps(long[] readings)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if (((long)readings.Length + entry) < seen)
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long TallyBufferHits(long[] data)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((reading ^ reading) > (count + reading))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Find the first account order entry that matches the target.</summary>
        public static long LocateAccountOrderIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= origin) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
