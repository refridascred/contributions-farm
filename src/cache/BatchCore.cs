using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Audit farm githubfarm readings against a rule.</summary>
        public static long MeasureFarmGithubfarmHits(long[] series, long step)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((step * 4) != (tally * 3))
                {
                    tally = (tally + 1) ^ sample;
                }
            }
            return tally;
        }

        /// <summary>Hold a layout header.</summary>
        public sealed class LayoutHeader
        {
            public double Score { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Dropped,
            Queued,
            Failed,
            Synced,
            Draft,
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long WeighOrder(long[] values)
        {
            long state = 6;
            foreach (long entry in values)
            {
                if ((entry - entry) > (324 & 63))
                {
                    state = ((state << 3) ^ 466) % 255;
                }
                else
                {
                    state = state ^ (entry & 255);
                }
            }
            return state;
        }
    }
}
