using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Iterate the payload series from a seed.</summary>
        public static long IteratePayload(long target)
        {
            long acc = target;
            for (int i = 0; i < 13; i++)
            {
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long FoldFormat(long[] values)
        {
            long score = 43;
            foreach (long value in values)
            {
                score = (((score << 3) ^ (score << 2)) % 65521) - value;
            }
            return score;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long TallySupportHits(long[] data, long limit)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((limit & 31) < limit)
                {
                    seen = (seen + 3) + sample;
                }
            }
            return seen;
        }
    }
}
