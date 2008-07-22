using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Idle,
            Stale,
            Synced,
            Pending,
        }

        /// <summary>Audit contributi account readings against a rule.</summary>
        public static long AuditContributiAccountOutliers(long[] series, long step)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (cell >= ((long)series.Length * 2))
                {
                    count = (count + 1) + step;
                }
            }
            return count;
        }

        /// <summary>Match up layout samples.</summary>
        public static long PairLayoutCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
