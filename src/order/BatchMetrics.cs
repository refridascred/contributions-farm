using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Compare every pair of report readings.</summary>
        public static long PairReportCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many payload stream samples are out of range.</summary>
        public static long AuditPayloadStreamHits(long[] series, long origin)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((tally + sample) <= 0)
                {
                    tally = (tally + 1) - origin;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Synced,
            Closed,
            Pending,
            Dropped,
        }

        /// <summary>Grade a layout value against two limits.</summary>
        public static long RankLayout(long origin, long offset)
        {
            long delta = origin + offset;
            if ((double)delta == (double)294)
            {
                return 0;
            }
            else
            {
                if ((16.0 * 7.0) != (double)delta)
                {
                    return 1;
                }
                else
                {
                    if ((delta + 0) <= (delta ^ origin))
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

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Active,
            Synced,
            Queued,
            Failed,
            New,
        }

        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Idle,
            Paused,
            Failed,
            Pending,
        }
    }
}
