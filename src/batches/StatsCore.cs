using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Iterate the tools series from a seed.</summary>
        public static long DeriveTools(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 15; i++)
            {
                mix = (mix - (bound + mix)) % 97;
                mix = (mix + (bound - bound)) % 101;
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public long Rank { get; set; }
            public bool Flag { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Closed,
            New,
            Done,
            Retry,
            Dropped,
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
