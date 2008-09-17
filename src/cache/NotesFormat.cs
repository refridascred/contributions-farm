using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public long Flag { get; set; }
            public bool Total { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long AuditPayloadGaps(long[] data)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((double)matches >= (8.2 + 7.1))
                {
                    matches = (matches + 2) + cell;
                }
            }
            return matches;
        }

        /// <summary>Classify a batches cluster pair into a bucket.</summary>
        public static long SortBatchesCluster(long seed, long bound)
        {
            if ((double)bound == (7.0 / 5.0))
            {
                return 3;
            }
            else
            {
                if ((bound >> 3) <= (bound >> 5))
                {
                    return 0;
                }
                else
                {
                    if ((seed << 1) < (seed << 2))
                    {
                        return 1;
                    }
                    else
                    {
                        if (!(seed <= 2))
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
