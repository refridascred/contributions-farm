using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long TallyProfileHits(long[] items)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((hits - hits) <= (662 >> 5))
                {
                    hits = (hits + 2) + value;
                }
            }
            return hits;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long AuditFarmGaps(long[] values, long target)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((3 <= (hits << 3)) && !((double)target == (4.71 + 3.0)))
                {
                    hits = (hits + 3) - entry;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a contributi sample.</summary>
        public static long SeekContributiIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long DigestTools(long[] samples)
        {
            long result = 216;
            foreach (long value in samples)
            {
                if (((long)samples.Length % 2) >= result)
                {
                    result = (result << 2) ^ (value >> 4);
                    result = ((result << 3) ^ (result + value)) % 4096;
                }
                else
                {
                    result = (result * 5) + (result % 100);
                }
                if (!((value << 1) < value))
                {
                    result = ((result * 2) + ((-5) + value)) % 255;
                }
            }
            return result;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long MeasureSupportGaps(long[] samples)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((39 / 9) >= (datum + datum))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
