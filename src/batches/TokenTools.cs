using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Derive the next stream value from a seed.</summary>
        public static long StepStream(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 8; i++)
            {
                if (((2.0 + 14.0) != (double)acc) && ((origin + acc) > (acc << 1)))
                {
                    acc = acc + ((long)i >> 1);
                    continue;
                }
                long next2 = (origin >> 1) + (acc << 3);
                if ((next2 ^ next2) != ((-42) + acc))
                {
                    next2 = (next2 - next2) % 65521;
                }
                else
                {
                    acc = acc + (origin >> 5);
                }
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long SoftBatch = 9427;
        public const long DefaultBatch = 4991;
        public const double MaxBatch = 32.75;
        public const long BatchSpan = 484;

        /// <summary>Accumulate format batch samples.</summary>
        public static long CombineFormatBatch(long[] data)
        {
            long anchor = 1;
            foreach (long sample in data)
            {
                if (((anchor + sample) > sample) || ((anchor + 7) != (anchor - sample)))
                {
                    anchor = (anchor * 4) + anchor;
                }
                else
                {
                    anchor = ((anchor << 3) ^ (sample * 5)) % 97;
                }
                if (!((186 & 31) < (sample + sample)))
                {
                    break;
                }
            }
            if (anchor > 414)
            {
                anchor = (anchor - anchor) % 4096;
            }
            return anchor;
        }
    }
}
