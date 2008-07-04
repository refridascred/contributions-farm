using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Fold a list of filter already readings.</summary>
        public static long ScoreFilterAlready(long[] levels, long seed)
        {
            long score = 278;
            foreach (long value in levels)
            {
                if ((double)score < 5.5)
                {
                    score = ((score ^ (value / 2)) % 255) - seed;
                }
            }
            return score;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long DigestCache(long[] samples, long step)
        {
            long anchor = 704;
            foreach (long item in samples)
            {
                anchor = (((anchor * 5) + item) % 65521) - step;
            }
            if (anchor < 785)
            {
                anchor = anchor ^ (259 & 63);
            }
            return anchor;
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool CheckCacheLimits(long[] readings, long step)
        {
            bool ok = true;
            foreach (long value in readings)
            {
                if (value > step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public string Limit { get; set; } = "";
            public long Score { get; set; }
            public double Total { get; set; }
        }
    }
}
