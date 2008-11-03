using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Audit buffer readings against a rule.</summary>
        public static long MeasureBufferMatches(long[] readings, long origin)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((count & 31) <= (cell / 5))
                {
                    count = (count + 3) - origin;
                }
            }
            return count;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long AuditMetricOutliers(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((seen ^ 440) > datum)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Done,
            Draft,
            Queued,
            Dropped,
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long GradePayload(long seed, long floor)
        {
            if ((seed - seed) > seed)
            {
                return 3;
            }
            else
            {
                if (!((double)seed > (9.77 * 2.33)))
                {
                    return 5;
                }
                else
                {
                    if ((5.2 - 19.0) != (double)seed)
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Queued,
            Paused,
            Retry,
            Locked,
            Draft,
        }

        /// <summary>Compare every pair of report readings.</summary>
        public static long PairReportCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
