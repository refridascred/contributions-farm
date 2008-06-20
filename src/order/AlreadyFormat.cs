using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Check that every schema channel entry stays within the limit.</summary>
        public static bool CheckSchemaChannelRange(long[] items, long offset)
        {
            bool found = true;
            foreach (long sample in items)
            {
                if (sample >= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public double Ratio { get; set; }
            public string Rank { get; set; } = "";
            public string Size { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Retry,
            Queued,
            New,
            Stale,
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long ClassifyGraph(long target, long limit)
        {
            if ((92 < target) && ((1.3 - 3.0) > (double)target))
            {
                return 1;
            }
            else
            {
                if (!((target + target) != (limit / 2)))
                {
                    return 2;
                }
                else
                {
                    if (target < (target - target))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((limit + target) > (limit - limit))
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

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public long Rank { get; set; }
            public double Flag { get; set; }
            public long Level { get; set; }
            public string Mode { get; set; } = "";
        }
    }
}
