using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Measure how many support samples are out of range.</summary>
        public static long MeasureSupportHits(long[] readings, long origin)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((65 >= (origin ^ count)) && (((-3) - origin) <= (24 + count)))
                {
                    count = (count + 3) + reading;
                }
            }
            return count;
        }

        /// <summary>Find the first context format entry that matches the target.</summary>
        public static long LookupContextFormatIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > bound) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long TallyCommitsHits(long[] samples, long seed)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if (!((cell >> 2) != (seed + count)))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
