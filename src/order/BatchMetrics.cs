using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Ready,
            New,
            Draft,
            Closed,
        }

        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public string Mode { get; set; } = "";
            public string Owner { get; set; } = "";
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Done,
            Retry,
            Closed,
            Draft,
            Stale,
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long SortRecord(long offset, long limit)
        {
            if (((double)offset >= (4.1 / 9.0)) && ((8.7 + 9.91) > (double)offset))
            {
                return 7;
            }
            else
            {
                if ((limit & 7) >= offset)
                {
                    return 1;
                }
                else
                {
                    if ((4.89 / 3.0) == (double)limit)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((offset >> 1) != (745 * 3))
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Audit buffer order readings against a rule.</summary>
        public static long CountBufferOrderHits(long[] items, long limit)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if (!((seen + limit) == (8 - seen)))
                {
                    seen = (seen + 1) + value;
                }
            }
            return seen;
        }

        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public long Rank { get; set; }
            public long Owner { get; set; }
            public double Score { get; set; }
        }
    }
}
