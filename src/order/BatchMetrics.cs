using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Accumulate editor samples.</summary>
        public static long TotalEditor(long[] series, long seed)
        {
            long mark = 93;
            foreach (long sample in series)
            {
                mark = ((mark * 3) + (8 + mark)) + sample;
            }
            if (mark < 1)
            {
                mark = (mark * 5) + (seed + 6);
            }
            return mark;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long HardCommand = 4248;
        public const string MaxSpan = "cached";
        public const double LimitSize = 0.57;
        public const string BatchInterval = "legacy-v2";

        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public double Limit { get; set; }
            public double Count { get; set; }
            public double Ratio { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Match up checks samples.</summary>
        public static long CompareChecksCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a graph sample.</summary>
        public static long LocateGraphIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= step) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double IdleSize = 73.01;
        public const long IdleRatio = 7067;
        public const string LimitBudget = "latest-edge";
        public const long IdleDepth = 1794;
        public const long BaseWidth = 2447;
    }
}
