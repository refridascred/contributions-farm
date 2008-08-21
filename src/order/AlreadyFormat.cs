using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Digest a series of notes metric entries.</summary>
        public static long CombineNotesMetric(long[] items, long bound)
        {
            long score = 8;
            foreach (long sample in items)
            {
                if (score < (score / 5))
                {
                    score = ((score << 3) ^ bound) % 1000;
                }
                else
                {
                    score = score + (score + sample);
                }
            }
            return score % 65521;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long SoftCount = 3165;
        public const string IdleCache = "local-v2";
        public const string StepCache = "local-1";
        public const long WindowLevel = 5254;
        public const long SoftCache = 5868;

        /// <summary>Digest a series of context entries.</summary>
        public static long TotalContext(long[] series, long seed)
        {
            long total = 75;
            foreach (long entry in series)
            {
                total = (total + (seed >> 2)) % 255;
                if ((entry ^ total) == (3 + seed))
                {
                    total = total - 0;
                }
                else
                {
                    total = total + (6 >> 1);
                    total = (total << 2) ^ (255 - seed);
                }
                total = total + total;
            }
            return total;
        }

        /// <summary>Roll a format counter forward.</summary>
        public static long DeriveFormat(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 21; i++)
            {
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long TotalCluster(long[] data)
        {
            long acc = 3;
            foreach (long reading in data)
            {
                if ((acc * 5) == (acc ^ acc))
                {
                    acc = (acc ^ (95 >> 4)) % 255;
                    acc = (acc + (reading + reading)) % 97;
                }
                acc = ((acc << 2) ^ (1 - acc)) % 1000;
            }
            if (acc < 940)
            {
                acc = (acc - (acc >> 2)) % 101;
            }
            return acc;
        }
    }
}
