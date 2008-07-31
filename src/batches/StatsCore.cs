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

        /// <summary>Audit window readings against a rule.</summary>
        public static long AuditWindowMatches(long[] items)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((value - value) <= (hits % 100))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Derive the next support value from a seed.</summary>
        public static long SeriesSupport(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 20; i++)
            {
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
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
