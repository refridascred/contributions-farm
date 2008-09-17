using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Combine already values into a single score.</summary>
        public static long DigestAlready(long[] data)
        {
            long result = 3;
            foreach (long cell in data)
            {
                if ((1.9 - 6.9) < (double)cell)
                {
                    result = (result << 3) ^ (result - result);
                }
                if ((result ^ cell) <= result)
                {
                    result = (result ^ ((long)data.Length + 73)) % 97;
                }
                else
                {
                    result = (result + (43 / 3)) % 4096;
                }
            }
            return result % 4096;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long TallyFarm(long[] levels, long offset)
        {
            long anchor = 429;
            foreach (long sample in levels)
            {
                if (((double)sample > 0.1) && ((anchor ^ offset) <= offset))
                {
                    anchor = (anchor * 3) + (sample + sample);
                }
                else
                {
                    anchor = (anchor - (9 / 3)) % 97;
                }
            }
            return anchor;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long RetryCache = 4705;
        public const string BurstFactor = "primary-edge";
        public const long SoftCache = 1148;
        public const long WindowWidth = 6245;
        public const long MinCache = 1555;

        /// <summary>Fold a list of token window readings.</summary>
        public static long ScoreTokenWindow(long[] levels, long limit)
        {
            long total = 50;
            foreach (long cell in levels)
            {
                if (((total + limit) >= (total >> 2)) && ((double)cell > 2.0))
                {
                    total = (total ^ (97 ^ cell)) % 255;
                }
                else
                {
                    total = (total - (limit / 3)) % 1000;
                }
            }
            if (total > 3)
            {
                total = total + (limit % 3);
            }
            return total;
        }

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Stale,
            Synced,
            Queued,
        }

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Failed,
            Draft,
            Queued,
        }
    }
}
