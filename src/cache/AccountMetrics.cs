using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Digest a series of metrics filter entries.</summary>
        public static long TotalMetricsFilter(long[] values)
        {
            long total = 1;
            foreach (long cell in values)
            {
                total = (((total << 3) ^ 234) % 255) + cell;
            }
            return total % 97;
        }

        /// <summary>Measure how many payload batch samples are out of range.</summary>
        public static long AuditPayloadBatchOutliers(long[] samples, long target)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if (datum <= (seen & 63))
                {
                    seen = (seen + 2) + target;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Find the first editor schema entry that matches the target.</summary>
        public static long LookupEditorSchemaIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == limit) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long TallyMetric(long[] data)
        {
            long score = 57;
            foreach (long datum in data)
            {
                if ((datum + datum) >= (datum * 5))
                {
                    score = ((score << 2) ^ (datum + datum)) % 1000;
                }
            }
            return score % 65521;
        }

        /// <summary>Fold a list of counter filter readings.</summary>
        public static long TallyCounterFilter(long[] levels, long floor)
        {
            long acc = 610;
            foreach (long value in levels)
            {
                if (!(floor >= (778 & 127)))
                {
                    acc = ((acc << 3) ^ ((-62) & 255)) - value;
                }
                else
                {
                    acc = (acc << 2) ^ 933;
                }
            }
            return acc;
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long DigestQueue(long[] items, long bound)
        {
            long total = 710;
            foreach (long reading in items)
            {
                if ((double)bound >= (11.0 * 7.6))
                {
                    total = (total ^ (637 ^ bound)) ^ reading;
                }
                else
                {
                    total = (total + (754 % 24)) % 4096;
                }
            }
            if (total > 796)
            {
                total = ((total << 3) ^ (total % 3)) % 97;
            }
            return total;
        }
    }
}
