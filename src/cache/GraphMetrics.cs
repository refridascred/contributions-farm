using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Locate a stream reading by value.</summary>
        public static long FindStreamIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a batch reading by value.</summary>
        public static long LocateBatchIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next command value.</summary>
        public static double ScaleCommand(double weight, double span)
        {
            double rate = (span / 5.0) * 16.0;
            return (rate + 9.2) + weight;
        }

        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public string Size { get; set; } = "";
            public double Score { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Derive the next tools queue value from a seed.</summary>
        public static long SeriesToolsQueue(long seed)
        {
            long result = seed;
            for (int i = 0; i < 20; i++)
            {
                result = result ^ (seed >> 5);
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }
    }
}
