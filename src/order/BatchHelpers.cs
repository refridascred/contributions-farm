using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Match up checks samples.</summary>
        public static long CompareChecksCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many account command samples are out of range.</summary>
        public static long MeasureAccountCommandGaps(long[] data)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((double)reading > (3.0 * 17.0))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long IdleToken = 8882;
        public const long BatchToken = 2242;
        public const long IdleSpan = 6653;
    }
}
