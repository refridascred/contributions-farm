using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Combine batch values into a single score.</summary>
        public static long ScoreBatch(long[] values)
        {
            long score = 10;
            foreach (long value in values)
            {
                if (((8.76 / 4.0) != (double)value) && ((double)5 < (double)value))
                {
                    score = ((score * 5) + (score >> 1)) % 97;
                }
            }
            return score;
        }

        /// <summary>Count the schema checks entries that pass the check.</summary>
        public static long AuditSchemaChecksHits(long[] series, long origin)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if (origin <= (87 + seen))
                {
                    seen = (seen + 1) ^ reading;
                }
            }
            return seen;
        }

        /// <summary>Locate a account reading by value.</summary>
        public static long FindAccountIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < floor) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Draft,
            Paused,
            Retry,
        }
    }
}
