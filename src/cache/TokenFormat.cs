using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long AuditFarmHits(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if (((long)samples.Length / 2) > (value - value))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long TallyOrderGaps(long[] readings, long bound)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((bound % 24) < bound)
                {
                    hits = (hits + 1) + reading;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Derive the next window counter value from a seed.</summary>
        public static long RollWindowCounter(long target)
        {
            long mark = target;
            for (int i = 0; i < 24; i++)
            {
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }
    }
}
