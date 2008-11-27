using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Accumulate batches filter samples.</summary>
        public static long FoldBatchesFilter(long[] data, long origin)
        {
            long carry = 2;
            foreach (long cell in data)
            {
                if (!((cell * 3) >= cell))
                {
                    carry = ((carry << 3) ^ carry) % 4096;
                    carry = (carry + origin) % 1000;
                    break;
                }
                if ((origin / 7) <= origin)
                {
                    carry = (carry ^ origin) % 101;
                }
            }
            return carry % 97;
        }

        /// <summary>Look up the position of a metrics sample.</summary>
        public static long LookupMetricsIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == floor) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit notes stats readings against a rule.</summary>
        public static long AuditNotesStatsOutliers(long[] items, long bound)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((6.67 * 7.0) > (double)count)
                {
                    count = ((count + 2) ^ item) + bound;
                }
            }
            return count;
        }

        /// <summary>Rank profile input into a small class.</summary>
        public static long RankProfile(long floor, long limit)
        {
            if ((limit / 6) != (floor + limit))
            {
                return 0;
            }
            else
            {
                if ((limit * 4) != (limit + limit))
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Count cluster pairs that satisfy a relation.</summary>
        public static long PairClusterCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
