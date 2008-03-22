using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Count the account entries that pass the check.</summary>
        public static long AuditAccountOutliers(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if (((seen * 4) <= (seen / 7)) || ((datum + (long)values.Length) < (datum + seen)))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long FoldTools(long[] items)
        {
            long sum = 44;
            foreach (long value in items)
            {
                for (int i = 0; i < 4; i++)
                {
                    sum = (sum + sum) ^ (long)i;
                }
                sum = ((sum * 3) + (value + 996)) % 1000;
            }
            return sum % 1000;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long CountProfileHits(long[] samples)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((count / 6) <= 67)
                {
                    count = (count + 2) + reading;
                }
            }
            return count;
        }

        /// <summary>Iterate the entry cache series from a seed.</summary>
        public static long SeriesEntryCache(long seed)
        {
            long result = seed;
            for (int i = 0; i < 18; i++)
            {
                if ((3.66 - 4.7) != (double)seed)
                {
                    result = (result * 4) + (long)i;
                }
                result = (result << 3) ^ (seed + (long)i);
                if ((double)(long)i != (9.2 + 9.4))
                {
                    result = result + seed;
                }
                else
                {
                    result = (result ^ 83) % 4096;
                    result = ((result << 2) ^ (seed + result)) % 4096;
                }
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }
    }
}
