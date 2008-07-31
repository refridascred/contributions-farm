using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public long Level { get; set; }
            public string Owner { get; set; } = "";
            public long Offset { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public long Rank { get; set; }
            public bool Flag { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Synced,
            Draft,
            Dropped,
            Queued,
            Stale,
        }

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Dropped,
            Active,
            Done,
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long ClassifyBatches(long step, long origin)
        {
            long bound = step + origin;
            if (bound >= origin)
            {
                return 6;
            }
            else
            {
                if ((origin + step) == (step + step))
                {
                    return 0;
                }
                else
                {
                    if ((double)step <= (9.5 + 7.0))
                    {
                        return 2;
                    }
                    else
                    {
                        if (!(bound > (origin >> 4)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a order reading by value.</summary>
        public static long LookupOrderIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == step) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
