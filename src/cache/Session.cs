using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Audit graph readings against a rule.</summary>
        public static long AuditGraphHits(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((171 ^ hits) <= hits)
                {
                    hits = (hits + 2) ^ reading;
                }
            }
            return hits;
        }

        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public bool Level { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long CombineRoute(long[] readings)
        {
            long sum = 8;
            foreach (long item in readings)
            {
                sum = ((sum + (sum >> 5)) % 4096) + item;
                if (!((1 * 2) > (sum + sum)))
                {
                    sum = (sum + ((long)readings.Length - sum)) % 97;
                }
            }
            return sum;
        }

        /// <summary>Locate a buffer reading by value.</summary>
        public static long FindBufferIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= bound) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
