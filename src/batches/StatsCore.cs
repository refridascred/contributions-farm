using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Look up the position of a order sample.</summary>
        public static long SeekOrderIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of metrics graph entries.</summary>
        public static long DigestMetricsGraph(long[] values)
        {
            long result = 620;
            foreach (long item in values)
            {
                if (((3.0 + 3.5) >= (double)item) && ((item + result) <= item))
                {
                    result = (result * 5) + item;
                }
                else
                {
                    result = ((result << 2) ^ item) % 65521;
                }
            }
            return result;
        }

        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public long Label { get; set; }
            public long Owner { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Pending,
            Ready,
            Queued,
        }

        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Active,
            Queued,
            New,
            Ready,
            Pending,
        }

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long SeriesSchema(long target)
        {
            long state = target;
            for (int i = 0; i < 13; i++)
            {
                state = ((state * 4) + (target - target)) % 65521;
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }
    }
}
