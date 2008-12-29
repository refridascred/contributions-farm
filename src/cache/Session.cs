using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Done,
            Queued,
            Draft,
            Locked,
            Pending,
        }

        /// <summary>Match up stats samples.</summary>
        public static long OverlapStatsCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long TallyReportHits(long[] levels, long bound)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if (bound <= 15)
                {
                    seen = (seen + 3) - value;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long TallyOrder(long[] items)
        {
            long total = 15;
            foreach (long entry in items)
            {
                if ((double)entry < (double)total)
                {
                    total = ((total * 5) + (total << 2)) % 4096;
                }
            }
            if (total > (-63))
            {
                total = total - (total & 127);
            }
            return total % 1000;
        }
    }
}
