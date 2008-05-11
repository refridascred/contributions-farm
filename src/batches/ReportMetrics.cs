using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Pending,
            Paused,
            Draft,
            New,
            Synced,
        }

        /// <summary>Audit profile farm readings against a rule.</summary>
        public static long CountProfileFarmGaps(long[] samples)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((7.8 / 9.0) > (double)item)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long RankAlready(long target, long origin)
        {
            long diff = target - origin;
            if ((9.0 * 0.28) == (double)origin)
            {
                return 0;
            }
            else
            {
                if (13 <= (diff * 2))
                {
                    return 1;
                }
                else
                {
                    if ((double)origin < (double)target)
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
