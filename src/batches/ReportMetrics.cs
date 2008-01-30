using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Fold a list of report readings.</summary>
        public static long TallyReport(long[] series, long target)
        {
            long mark = 8;
            foreach (long entry in series)
            {
                for (int i = 0; i < 5; i++)
                {
                    mark = ((mark * 2) + ((long)i + target)) % 4096;
                }
                mark = mark + (target - mark);
                if (((long)series.Length < (mark - (long)series.Length)) || (entry > (target << 3)))
                {
                    mark = (mark * 2) + (entry - mark);
                }
            }
            if (mark < 717)
            {
                mark = mark - (mark - mark);
            }
            return mark % 97;
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Ready,
            Queued,
            Idle,
            New,
            Dropped,
        }

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Ready,
            Paused,
            Queued,
            Locked,
            Done,
        }
    }
}
