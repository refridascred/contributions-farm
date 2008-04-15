using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Match up account samples.</summary>
        public static long CompareAccountCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long CountPayloadOutliers(long[] data, long bound)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((2 << 2) > (tally - bound))
                {
                    tally = (tally + 3) + cell;
                }
            }
            return tally;
        }

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public long Region { get; set; }
            public bool Mode { get; set; }
            public long Ratio { get; set; }
            public double Level { get; set; }
        }
    }
}
