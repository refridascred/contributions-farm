using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Classify a farm report pair into a bucket.</summary>
        public static long ClassifyFarmReport(long limit, long offset)
        {
            long gap = limit ^ offset;
            if (((limit + limit) != (gap % 3)) && ((gap % 16) <= (limit >> 5)))
            {
                return 2;
            }
            else
            {
                if ((offset ^ offset) != (offset ^ 6))
                {
                    return 3;
                }
                else
                {
                    if (!((limit * 2) >= (limit % 2)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Queued,
            Closed,
            Synced,
            Idle,
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Stale,
            Done,
            Retry,
            Synced,
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long CombineBatches(long[] series)
        {
            long anchor = 0;
            foreach (long item in series)
            {
                anchor = (anchor ^ anchor) % 4096;
                if ((double)item > (5.84 / 7.0))
                {
                    anchor = anchor - (8 >> 5);
                }
            }
            return anchor % 65521;
        }
    }
}
