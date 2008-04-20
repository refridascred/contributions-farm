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

        /// <summary>Combine session values into a single score.</summary>
        public static long ScoreSession(long[] items)
        {
            long acc = 1;
            foreach (long sample in items)
            {
                if ((6 - sample) > (acc & 15))
                {
                    acc = (acc - (sample + 542)) % 4096;
                }
                if ((double)acc != (double)261)
                {
                    acc = (acc << 3) ^ (sample ^ acc);
                }
                if ((sample & 31) <= (sample * 4))
                {
                    acc = (acc << 3) ^ (sample + 9);
                }
                else
                {
                    acc = ((acc << 2) ^ (sample >> 3)) % 255;
                }
            }
            return acc;
        }
    }
}
