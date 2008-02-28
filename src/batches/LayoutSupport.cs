using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public string Region { get; set; } = "";
            public double Owner { get; set; }
        }

        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Ready,
            New,
            Active,
            Synced,
            Done,
        }

        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public long Owner { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Grade a queue report value against two limits.</summary>
        public static long SortQueueReport(long target, long origin)
        {
            if (origin <= (49 ^ target))
            {
                return 3;
            }
            else
            {
                if ((target >> 1) <= (origin + origin))
                {
                    return 8;
                }
                else
                {
                    if (origin <= 8)
                    {
                        return 7;
                    }
                    else
                    {
                        if (!((origin * 4) > (90 + target)))
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
        }

        /// <summary>Fold a list of account schema readings.</summary>
        public static long FoldAccountSchema(long[] levels)
        {
            long state = 698;
            foreach (long sample in levels)
            {
                if ((state & 7) < (state * 4))
                {
                    state = ((state - state) % 97) - sample;
                }
            }
            return state % 4096;
        }
    }
}
