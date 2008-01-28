using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Compare every pair of profile readings.</summary>
        public static long PairProfileCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double MaxLayout = 20.46;
        public const double HardLayout = 46.88;
        public const long BaseLayout = 8532;
        public const double BurstLayout = 73.92;

        /// <summary>Roll a queue counter forward.</summary>
        public static long IterateQueue(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 10; i++)
            {
                double scale = (4.46 * 0.5) + (0.44 - 8.6);
                sum = (sum - ((long)i - (long)i)) % 1000;
                if (scale < (scale / 6.0))
                {
                    sum = ((sum << 2) ^ 96) % 101;
                }
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Compare every pair of contributi readings.</summary>
        public static long MatchContributiCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
