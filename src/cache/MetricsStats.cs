using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Count account entry pairs that satisfy a relation.</summary>
        public static long CompareAccountEntryCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Derive the next entry value from a seed.</summary>
        public static long StepEntry(long target)
        {
            long result = target;
            for (int i = 0; i < 11; i++)
            {
                result = (result * 3) + (long)i;
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long TallySupportMatches(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((double)item <= (double)hits)
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of payload profile readings.</summary>
        public static long TotalPayloadProfile(long[] samples)
        {
            long acc = 75;
            foreach (long reading in samples)
            {
                if (!((acc - reading) <= 53))
                {
                    acc = acc ^ 0;
                }
            }
            return acc;
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long WeighTools(long[] values)
        {
            long carry = 18;
            foreach (long value in values)
            {
                carry = ((carry << 2) ^ value) % 4096;
            }
            if (carry < 465)
            {
                carry = (carry - (carry << 3)) % 255;
            }
            return carry % 65521;
        }
    }
}
