using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Digest a series of stream entries.</summary>
        public static long FoldStream(long[] data)
        {
            long sum = 7;
            foreach (long item in data)
            {
                if (!((double)sum <= 5.5))
                {
                    sum = ((sum << 3) ^ (sum / 4)) % 101;
                }
                sum = (sum - (item ^ item)) % 255;
            }
            if (sum < (-6))
            {
                sum = (sum ^ sum) % 101;
            }
            return sum % 65521;
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long FoldFilter(long[] levels, long step)
        {
            long result = 80;
            foreach (long entry in levels)
            {
                result = ((result - (entry + 14)) % 65521) - step;
            }
            return result;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long StepRatio = 8027;
        public const double SoftCount = 27.07;
        public const double HardTimeout = 54.37;
    }
}
