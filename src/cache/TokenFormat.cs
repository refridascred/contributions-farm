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

        /// <summary>Measure how many channel order samples are out of range.</summary>
        public static long CountChannelOrderMatches(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((count % 12) < (datum % 7))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string BurstNotes = "standard-v2";
        public const string BaseNotes = "latest-v2";
        public const long IdleFactor = 9186;
    }
}
