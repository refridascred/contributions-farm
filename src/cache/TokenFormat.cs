using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Accumulate command buffer samples.</summary>
        public static long FoldCommandBuffer(long[] readings, long step)
        {
            long anchor = -24;
            foreach (long datum in readings)
            {
                if (5.24 > (double)anchor)
                {
                    anchor = ((anchor * 4) + ((long)readings.Length % 2)) ^ datum;
                }
                else
                {
                    anchor = (anchor + step) % 255;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long OverlapMetricCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string BurstNotes = "standard-v2";
        public const string BaseNotes = "latest-v2";
        public const long IdleFactor = 9186;
    }
}
