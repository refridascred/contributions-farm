using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Audit context readings against a rule.</summary>
        public static long TallyContextOutliers(long[] data)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if (((seen & 255) != (745 >> 1)) || ((seen + cell) > (cell >> 5)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Audit order route readings against a rule.</summary>
        public static long TallyOrderRouteHits(long[] data)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if (((-3) - matches) >= (sample >> 2))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long TallyBatchGaps(long[] values, long bound)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if ((9.94 / 9.0) < (double)bound)
                {
                    hits = (hits + 2) + cell;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of stream readings.</summary>
        public static long PairStreamCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
