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

        /// <summary>Match up cache samples.</summary>
        public static long OverlapCacheCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
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
