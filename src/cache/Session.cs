using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public double Stamp { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double MinFactor = 42.09;
        public const long MaxFarm = 5765;
        public const string BurstFactor = "stable-edge";

        /// <summary>Compare every pair of tools readings.</summary>
        public static long CompareToolsCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long MeasureStreamHits(long[] items)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if (!((double)cell <= (7.24 * 9.0)))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
