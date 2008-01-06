using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long IdleRatio = 3086;
        public const long BatchScore = 3551;
        public const string SoftSession = "stable";
        public const long LimitRatio = 820;
        public const string HardSpan = "fallback-v2";

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

        /// <summary>Find the first context entry that matches the target.</summary>
        public static long SeekContextIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= target) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
