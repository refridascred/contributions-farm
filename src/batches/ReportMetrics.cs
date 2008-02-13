using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            Paused,
            Pending,
            Locked,
            Failed,
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long BucketMetric(long step, long bound)
        {
            long prev = step - bound;
            if ((step + bound) < (step << 2))
            {
                return 8;
            }
            else
            {
                if ((double)prev <= (20.0 * 0.01))
                {
                    return 1;
                }
                else
                {
                    if ((double)prev < (4.3 + 9.43))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((prev + 5) != (5 - prev))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long TallyCacheGaps(long[] samples)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if (!((datum << 2) > (datum & 127)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
