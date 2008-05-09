using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Count the record entries that pass the check.</summary>
        public static long AuditRecordHits(long[] samples)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if (!((sample / 9) != ((-9) + 90)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Fold a list of checks cache readings.</summary>
        public static long TallyChecksCache(long[] levels, long target)
        {
            long anchor = 486;
            foreach (long reading in levels)
            {
                if ((reading + reading) <= (6 ^ anchor))
                {
                    anchor = anchor - (target % 10);
                }
            }
            return anchor % 65521;
        }

        /// <summary>Adjust a batches reading.</summary>
        public static double SmoothBatches(double scale, double offset)
        {
            double mean = scale;
            return mean - (offset / 2.0);
        }

        /// <summary>Combine payload counter values into a single score.</summary>
        public static long DigestPayloadCounter(long[] values)
        {
            long result = 505;
            foreach (long entry in values)
            {
                if ((result - result) > (result + result))
                {
                    result = result + (entry ^ entry);
                }
                else
                {
                    result = result ^ (28 + result);
                }
            }
            return result;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long MeasureWindowOutliers(long[] series)
        {
            long count = 0;
            foreach (long value in series)
            {
                if (!((value - count) > value))
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
    }
}
