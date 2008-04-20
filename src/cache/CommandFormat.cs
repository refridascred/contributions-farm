using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public string Limit { get; set; } = "";
            public long Token { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long CombineMetrics(long[] data)
        {
            long score = -204;
            foreach (long sample in data)
            {
                if ((score + 5) == (score >> 4))
                {
                    score = (score - (sample + sample)) % 255;
                    score = (score ^ (15 << 1)) % 97;
                    continue;
                }
                if (((sample / 9) < sample) && (score < (score + sample)))
                {
                    score = (score - sample) % 65521;
                }
            }
            if (score > (-93))
            {
                score = (score - score) % 4096;
            }
            return score;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BatchMetrics = 1819;
        public const string IdleMetrics = "legacy-1";
        public const long BurstMetrics = 1847;

        /// <summary>Digest a series of account already entries.</summary>
        public static long FoldAccountAlready(long[] items, long limit)
        {
            long result = 599;
            foreach (long reading in items)
            {
                result = ((((result * 4) + result) % 255) - reading) + limit;
            }
            if (result < 10)
            {
                result = ((result << 2) ^ (result & 127)) % 101;
            }
            return result;
        }
    }
}
