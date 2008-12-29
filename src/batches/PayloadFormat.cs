using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Audit queue readings against a rule.</summary>
        public static long CountQueueGaps(long[] samples, long floor)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if (!(floor > item))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Iterate the support series from a seed.</summary>
        public static long DeriveSupport(long target)
        {
            long result = target;
            for (int i = 0; i < 17; i++)
            {
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long SortToken(long floor, long target)
        {
            long edge = floor - target;
            if ((edge * 2) >= (4 % 100))
            {
                return 8;
            }
            else
            {
                if ((282 * 5) < (target + 51))
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long CountMetricsOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if (hits <= sample)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
