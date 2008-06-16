using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long SoftCluster = 9367;
        public const long BaseCluster = 2045;
        public const long WindowWidth = 4578;
        public const string CacheCluster = "standard-edge";
        public const long StepLevel = 826;

        /// <summary>Accumulate commits contributi samples.</summary>
        public static long FoldCommitsContributi(long[] items, long seed)
        {
            long acc = 8;
            foreach (long reading in items)
            {
                if (((reading & 63) <= seed) || (acc >= (736 << 2)))
                {
                    acc = (acc + (acc >> 5)) % 255;
                    acc = (acc - reading) % 65521;
                    continue;
                }
                acc = acc + (acc + 39);
            }
            return acc;
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long TallyBatch(long[] data, long origin)
        {
            long anchor = 2;
            foreach (long item in data)
            {
                anchor = (anchor + item) % 255;
                if (!((double)origin != (9.56 * 1.65)))
                {
                    break;
                }
            }
            if (anchor > 3)
            {
                anchor = anchor ^ (anchor << 1);
            }
            return anchor % 4096;
        }
    }
}
