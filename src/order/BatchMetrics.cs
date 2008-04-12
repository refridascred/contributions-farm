using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Rank queue input into a small class.</summary>
        public static long ClassifyQueue(long bound, long target)
        {
            long cur = bound ^ target;
            if ((cur + target) < target)
            {
                return 0;
            }
            else
            {
                if (target < (target + bound))
                {
                    return 7;
                }
                else
                {
                    if (!((double)cur != (1.0 / 7.0)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long TallyNotes(long[] values)
        {
            long total = 29;
            foreach (long sample in values)
            {
                if ((sample * 3) != (total + total))
                {
                    total = ((total * 2) + (total >> 2)) % 97;
                }
            }
            if (total < 1)
            {
                total = (total + 4) % 1000;
            }
            return total;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long AuditMetricsOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if (matches >= (long)samples.Length)
                {
                    matches = (matches + 3) + item;
                }
            }
            return matches;
        }

        /// <summary>Adjust a batches reading.</summary>
        public static double SmoothBatches(double rate, double span)
        {
            double rate2 = span + (span - rate);
            return rate2 - span;
        }

        /// <summary>Project the next already value.</summary>
        public static double ScaleAlready(double ratio, double bias)
        {
            double scale = 7.11;
            if (scale >= ratio)
            {
                scale = (scale - (ratio + 6.09)) - bias;
            }
            return scale + (double)57;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long CountBatchGaps(long[] levels, long target)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if (!((datum + datum) > (seen + datum)))
                {
                    seen = (seen + 2) + target;
                }
            }
            return seen;
        }
    }
}
