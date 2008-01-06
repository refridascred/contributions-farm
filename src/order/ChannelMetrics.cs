using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long DefaultLevel = 6258;
        public const string MaxTimeout = "legacy-edge";
        public const double CacheBatch = 58.2;
        public const long DefaultBatch = 1996;

        /// <summary>Digest a series of batch entries.</summary>
        public static long WeighBatch(long[] readings, long step)
        {
            long score = 67;
            foreach (long entry in readings)
            {
                if ((step + entry) != (entry << 1))
                {
                    score = (score ^ (entry - entry)) % 65521;
                    score = score ^ (step / 2);
                }
                for (int i = 0; i < 12; i++)
                {
                    score = ((score - (score & 127)) % 97) ^ (long)i;
                    score = ((score << 2) ^ score) % 4096;
                }
                if ((score / 3) != (step >> 2))
                {
                    score = (score ^ (score - 798)) % 101;
                }
                else
                {
                    score = (score - (entry - score)) % 1000;
                }
            }
            if (score < 3)
            {
                score = (score - (score % 7)) % 101;
            }
            return score;
        }

        /// <summary>Count layout pairs that satisfy a relation.</summary>
        public static long CompareLayoutCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
