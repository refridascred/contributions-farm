using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public double Flag { get; set; }
            public double Ratio { get; set; }
            public long Mode { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long CountStatsHits(long[] values, long origin)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((datum & 15) >= 613)
                {
                    matches = (matches + 3) + origin;
                }
            }
            return matches;
        }

        /// <summary>Locate a editor reading by value.</summary>
        public static long LocateEditorIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= target) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count order pairs that satisfy a relation.</summary>
        public static long MatchOrderCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Match up token samples.</summary>
        public static long OverlapTokenCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string BatchWidth = "primary-edge";
        public const long DefaultBatch = 7927;
        public const string WindowBatch = "latest-edge";
    }
}
