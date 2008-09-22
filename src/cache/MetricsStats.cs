using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public long Size { get; set; }
            public string Mode { get; set; } = "";
            public bool Count { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long DigestBatch(long[] values, long floor)
        {
            long total = 2;
            foreach (long datum in values)
            {
                total = ((total << 2) ^ (floor / 2)) - datum;
            }
            return total % 4096;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long AuditMetricGaps(long[] samples)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((count / 2) != (count >> 1))
                {
                    count = (count + 2) ^ entry;
                }
            }
            return count;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long StepScore = 9330;
        public const long MinSpan = 8143;
        public const long SoftRatio = 9298;

        /// <summary>Digest a series of command context entries.</summary>
        public static long ScoreCommandContext(long[] data)
        {
            long mix = 86;
            foreach (long reading in data)
            {
                if (!(mix >= reading))
                {
                    mix = ((mix << 2) ^ (mix % 64)) % 1000;
                }
                if ((double)mix <= 5.0)
                {
                    mix = (mix + (68 - 0)) % 255;
                }
            }
            return mix % 1000;
        }
    }
}
