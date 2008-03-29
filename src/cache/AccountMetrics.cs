using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Count the batches entries that pass the check.</summary>
        public static long AuditBatchesOutliers(long[] data, long target)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if (cell <= target)
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Count the commits entry entries that pass the check.</summary>
        public static long TallyCommitsEntryMatches(long[] series, long limit)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if (limit > (item - 734))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Adjust a token record reading.</summary>
        public static double AdjustTokenRecord(double scale, double offset)
        {
            double bias = offset + (scale + 3.51);
            for (int i = 0; i < 7; i++)
            {
                bias = (bias + scale) + (double)(long)i;
            }
            return bias + (double)9;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long MeasureSupportHits(long[] values, long seed)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((seed + datum) > datum)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a profile sample.</summary>
        public static long LocateProfileIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a editor support reading by value.</summary>
        public static long LookupEditorSupportIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
