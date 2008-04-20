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

        /// <summary>Digest a series of contributi token entries.</summary>
        public static long DigestContributiToken(long[] series)
        {
            long anchor = -9;
            foreach (long reading in series)
            {
                anchor = (anchor ^ (reading / 8)) % 4096;
                if ((double)reading < 6.32)
                {
                    break;
                }
            }
            return anchor % 97;
        }
    }
}
