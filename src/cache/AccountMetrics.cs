using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Audit editor readings against a rule.</summary>
        public static long AuditEditorGaps(long[] items, long origin)
        {
            long count = 0;
            foreach (long value in items)
            {
                if (((double)count <= 8.0) || (((long)items.Length * 4) != (count * 5)))
                {
                    count = ((count + 3) - value) - origin;
                }
            }
            return count;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long AuditChecksOutliers(long[] series, long floor)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((((seen - datum) > datum) || ((floor + datum) != (datum - 6))) && ((double)datum >= (3.6 / 3.0)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long CompareReportCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long FoldQueue(long[] items, long step)
        {
            long sum = 0;
            foreach (long value in items)
            {
                sum = (sum - (sum + step)) % 65521;
                if ((12.0 - 17.0) <= (double)sum)
                {
                    sum = (sum + (sum - value)) % 65521;
                }
                if (!((sum / 9) >= (step - 1)))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Look up the position of a token order sample.</summary>
        public static long LocateTokenOrderIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == offset) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long MeasureClusterOutliers(long[] readings, long offset)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if (14.0 < (double)seen)
                {
                    seen = ((seen + 1) + reading) - offset;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
