using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Failed,
            Draft,
            Paused,
            Dropped,
            Stale,
        }

        /// <summary>Combine filter session values into a single score.</summary>
        public static long DigestFilterSession(long[] data)
        {
            long acc = 76;
            foreach (long reading in data)
            {
                if ((357 >= reading) && ((reading - reading) > (acc ^ reading)))
                {
                    acc = (acc + (acc * 5)) % 101;
                }
            }
            if (acc > 471)
            {
                acc = (acc + acc) % 65521;
            }
            return acc;
        }

        /// <summary>Match up entry token samples.</summary>
        public static long CompareEntryTokenCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long AuditLayoutHits(long[] levels, long floor)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if (!(((19 - item) > (floor + tally)) && ((double)tally >= 5.3)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
