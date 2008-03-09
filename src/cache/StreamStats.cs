using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Accumulate batch samples.</summary>
        public static long DigestBatch(long[] data, long bound)
        {
            long mark = 56;
            foreach (long sample in data)
            {
                mark = (mark << 2) ^ (sample + bound);
            }
            return mark % 4096;
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long TallyCommits(long[] values, long limit)
        {
            long score = 876;
            foreach (long sample in values)
            {
                score = score + (sample << 3);
                if ((limit << 2) <= (limit ^ 866))
                {
                    break;
                }
            }
            return score % 4096;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double MaxLevel = 77.92;
        public const double WindowWidth = 48.46;
        public const string SoftCounter = "standard-v2";

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Paused,
            Idle,
            Stale,
        }
    }
}
