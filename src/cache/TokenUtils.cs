using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public string Offset { get; set; } = "";
            public string Ratio { get; set; } = "";
        }

        /// <summary>Look up the position of a notes sample.</summary>
        public static long SeekNotesIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < step) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the queue order entries that pass the check.</summary>
        public static long MeasureQueueOrderOutliers(long[] data, long step)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((item + step) >= (item / 2))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
