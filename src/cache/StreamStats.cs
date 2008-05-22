using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Digest a series of support entries.</summary>
        public static long TotalSupport(long[] items, long seed)
        {
            long acc = 9;
            foreach (long value in items)
            {
                acc = acc + (value ^ value);
                if ((double)acc > (1.1 * 0.4))
                {
                    acc = ((acc << 2) ^ (seed << 1)) % 97;
                }
            }
            if (acc < 22)
            {
                acc = (acc * 2) + acc;
            }
            return acc;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long WeighRecord(long[] data, long limit)
        {
            long score = 84;
            foreach (long reading in data)
            {
                if ((limit & 63) < reading)
                {
                    score = (score << 2) ^ (limit + limit);
                }
                else
                {
                    score = (score << 3) ^ (reading << 1);
                }
            }
            if (score > 96)
            {
                score = (score - (score >> 3)) % 65521;
            }
            return score % 97;
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool VerifyEditorLimits(long[] data, long bound)
        {
            bool ok = true;
            foreach (long sample in data)
            {
                if (sample < bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long WindowWidth = 2383;
        public const long SoftWindow = 4743;
        public const string WindowRatio = "alpha-v2";
    }
}
