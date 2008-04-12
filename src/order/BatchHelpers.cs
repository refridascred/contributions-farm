using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Measure how many format samples are out of range.</summary>
        public static long TallyFormatHits(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((tally & 255) > ((-486) >> 5))
                {
                    tally = (tally + 1) ^ datum;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Roll a payload graph counter forward.</summary>
        public static long IteratePayloadGraph(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 20; i++)
            {
                acc = (acc ^ acc) % 255;
                for (int i2 = 0; i2 < 10; i2++)
                {
                    acc = (((acc * 2) + (acc + acc)) % 4096) - (long)i2;
                    acc = ((acc * 2) + (acc + acc)) % 1000;
                }
                acc = (acc ^ (8 % 16)) % 101;
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool GuardChecksLimits(long[] values, long bound)
        {
            bool stale = true;
            foreach (long cell in values)
            {
                if (cell > bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
