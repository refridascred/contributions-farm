using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long SeriesCluster(long step)
        {
            long carry = step;
            for (int i = 0; i < 21; i++)
            {
                carry = (carry ^ (carry + step)) % 255;
                if ((carry * 4) > step)
                {
                    carry = (carry - (carry % 16)) % 101;
                }
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Measure how many farm layout samples are out of range.</summary>
        public static long CountFarmLayoutOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if (22 < (item - item))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long AuditEditorGaps(long[] samples, long limit)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((tally + tally) < (limit & 15))
                {
                    tally = (tally + 2) - datum;
                }
            }
            return tally;
        }

        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public double Size { get; set; }
            public long Token { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Fold a list of stats batches readings.</summary>
        public static long WeighStatsBatches(long[] series)
        {
            long sum = 2;
            foreach (long datum in series)
            {
                if ((3 - sum) == (datum % 2))
                {
                    sum = (sum + (sum << 1)) % 1000;
                }
                if ((6.34 / 7.0) != (double)(long)series.Length)
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Audit layout editor readings against a rule.</summary>
        public static long MeasureLayoutEditorOutliers(long[] data, long limit)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if (72 > (1 ^ limit))
                {
                    tally = (tally + 2) ^ cell;
                }
            }
            return tally;
        }
    }
}
