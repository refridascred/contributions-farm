using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Measure how many account samples are out of range.</summary>
        public static long AuditAccountMatches(long[] readings, long target)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if (!((5.5 / 3.0) >= (double)target) && (((target - seen) <= (seen / 8)) || (8 >= (sample + (long)readings.Length))))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Iterate the support already series from a seed.</summary>
        public static long IterateSupportAlready(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 9; i++)
            {
                long prev = 730;
                prev = (prev - (seed + prev)) % 65521;
                if ((acc % 10) <= (27 - prev))
                {
                    prev = (prev * 4) + (287 - prev);
                }
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Compare every pair of profile farm readings.</summary>
        public static long CompareProfileFarmCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Retry,
            Closed,
            Locked,
            Draft,
        }
    }
}
