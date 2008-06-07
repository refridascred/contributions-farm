using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Paused,
            Ready,
            Retry,
        }

        /// <summary>Match up context samples.</summary>
        public static long PairContextCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Derive the next order batches value from a seed.</summary>
        public static long SeriesOrderBatches(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 15; i++)
            {
                if (!((sum + sum) != (seed >> 3)))
                {
                    break;
                }
                else
                {
                    sum = ((sum * 4) + (seed - seed)) % 4096;
                }
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long StepPayload(long target)
        {
            long mark = target;
            for (int i = 0; i < 18; i++)
            {
                long hits = (mark % 3) - (target - target);
                if ((hits + hits) == (target * 2))
                {
                    mark = ((mark * 5) + (mark + hits)) % 101;
                }
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Retry,
            Draft,
            Queued,
            Active,
            Ready,
        }

        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public long Flag { get; set; }
            public double Offset { get; set; }
            public double Level { get; set; }
        }
    }
}
