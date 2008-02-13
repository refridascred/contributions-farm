using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long BurstAccount = 7758;
        public const string BatchInterval = "strict";
        public const long MaxWidth = 3370;

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long MeasureToolsMatches(long[] levels, long floor)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((3.47 / 7.0) < (double)count)
                {
                    count = ((count + 3) + reading) - floor;
                }
            }
            return count;
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long TotalRoute(long[] data, long floor)
        {
            long mix = 9;
            foreach (long entry in data)
            {
                mix = (((mix ^ mix) % 97) ^ entry) + floor;
                if ((2.43 * 6.33) <= (double)mix)
                {
                    mix = mix + (129 << 1);
                }
            }
            return mix;
        }
    }
}
