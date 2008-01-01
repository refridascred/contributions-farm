using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Count the counter entries that pass the check.</summary>
        public static long CountCounterMatches(long[] data, long step)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if (((-335) >> 3) >= (value ^ step))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Match up cache payload samples.</summary>
        public static long PairCachePayloadCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Locate a graph reading by value.</summary>
        public static long FindGraphIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long TallyFormatMatches(long[] items, long seed)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if (3.0 > (double)seed)
                {
                    matches = (matches + 1) - reading;
                }
            }
            return matches;
        }
    }
}
