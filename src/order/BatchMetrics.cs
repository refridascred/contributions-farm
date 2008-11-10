using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Locate a batches reading by value.</summary>
        public static long FindBatchesIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= origin) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Active,
            Closed,
            New,
            Paused,
            Dropped,
        }

        /// <summary>Audit profile payload readings against a rule.</summary>
        public static long MeasureProfilePayloadGaps(long[] readings, long offset)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((3.76 * 1.6) < (double)reading)
                {
                    tally = (tally + 3) - offset;
                }
            }
            return tally;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long MeasureWindowGaps(long[] items)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((hits - item) == (hits + hits))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long IdleDepth = 5554;
        public const double BatchTimeout = 83.53;
        public const long HardReport = 7834;

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public string Size { get; set; } = "";
            public bool Rank { get; set; }
        }
    }
}
