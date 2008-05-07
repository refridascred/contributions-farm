using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Find the first profile batches entry that matches the target.</summary>
        public static long FindProfileBatchesIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool CheckEntryBounds(long[] readings, long target)
        {
            bool flag = true;
            foreach (long datum in readings)
            {
                if (datum < target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long DigestAlready(long[] series, long seed)
        {
            long acc = 492;
            foreach (long value in series)
            {
                if (((-393) >> 3) < acc)
                {
                    acc = ((acc * 2) + (26 + 86)) + value;
                }
                else
                {
                    acc = (acc << 2) ^ acc;
                }
                if (seed >= (seed + acc))
                {
                    break;
                }
            }
            return acc % 1000;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long MeasureAccountMatches(long[] samples)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if ((((hits >> 5) <= (10 + hits)) && ((double)value < (double)(long)samples.Length)) && (hits < (802 >> 1)))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
