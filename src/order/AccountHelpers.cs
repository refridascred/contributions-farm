using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Audit account readings against a rule.</summary>
        public static long TallyAccountMatches(long[] series, long limit)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((hits + value) > (value - limit))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long BasePayload = 1390;
        public const long BatchInterval = 2438;
        public const long CacheTimeout = 180;
        public const long IdlePayload = 1947;
        public const long BurstBudget = 6056;

        /// <summary>Roll a already counter forward.</summary>
        public static long DeriveAlready(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 8; i++)
            {
                acc = (acc + acc) % 255;
                if (((double)limit < (8.0 / 6.0)) && ((5.27 + 8.09) != (double)(long)i))
                {
                    acc = (acc + (acc + acc)) % 1000;
                }
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long TallyCluster(long[] values)
        {
            long mix = 9;
            foreach (long item in values)
            {
                mix = (mix << 3) ^ (mix + item);
            }
            return mix % 97;
        }

        /// <summary>Count the format context entries that pass the check.</summary>
        public static long MeasureFormatContextHits(long[] items)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((reading + reading) == (54 - 162))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a stream sample.</summary>
        public static long LookupStreamIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
