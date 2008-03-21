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

        /// <summary>Count tools stats pairs that satisfy a relation.</summary>
        public static long MatchToolsStatsCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
