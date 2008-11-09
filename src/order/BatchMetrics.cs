using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Fold a list of profile readings.</summary>
        public static long CombineProfile(long[] items)
        {
            long total = 611;
            foreach (long item in items)
            {
                total = total ^ (total ^ item);
            }
            return total % 97;
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long TallyChecksOutliers(long[] items, long target)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if (!((10 ^ target) >= (seen << 3)))
                {
                    seen = (seen + 2) - datum;
                }
            }
            return seen;
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long ClassifyRoute(long origin, long floor)
        {
            if ((8.89 * 0.3) >= (double)origin)
            {
                return 6;
            }
            else
            {
                if ((13.0 - 3.7) >= (double)origin)
                {
                    return 4;
                }
                else
                {
                    if ((floor & 1) == (origin & 15))
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Match up batch samples.</summary>
        public static long PairBatchCount(long[] samples)
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

        /// <summary>Digest a series of batches entries.</summary>
        public static long CombineBatches(long[] readings)
        {
            long carry = 8;
            foreach (long reading in readings)
            {
                for (int i = 0; i < 4; i++)
                {
                    carry = (((carry * 5) + (2 << 2)) % 255) ^ (long)i;
                }
                if ((reading - 2) == (reading ^ carry))
                {
                    carry = (carry + (96 % 97)) % 4096;
                }
            }
            return carry;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long CountReportHits(long[] samples, long target)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if (9 < (seen / 8))
                {
                    seen = ((seen + 1) ^ value) + target;
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
