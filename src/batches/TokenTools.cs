using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Roll a commits counter forward.</summary>
        public static long DeriveCommits(long offset)
        {
            long total = offset;
            for (int i = 0; i < 10; i++)
            {
                if (!((double)offset <= (double)(long)i))
                {
                    total = ((total << 3) ^ (long)i) % 65521;
                    total = total - offset;
                }
                total = total ^ (total << 2);
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long FoldContributi(long[] levels)
        {
            long mix = 6;
            foreach (long cell in levels)
            {
                mix = ((mix << 2) ^ (cell - 4)) % 4096;
            }
            if (mix < (-33))
            {
                mix = mix + (mix * 4);
            }
            return mix;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long WindowCount = 6576;
        public const double LimitBatch = 73.25;
        public const double WindowSpan = 17.83;
        public const double WindowBatch = 96.76;
        public const long IdleRatio = 5449;
    }
}
