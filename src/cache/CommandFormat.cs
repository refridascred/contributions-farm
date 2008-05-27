using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public bool Limit { get; set; }
            public string Label { get; set; } = "";
            public double Level { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool CheckCommitsRange(long[] items, long bound)
        {
            bool found = true;
            foreach (long entry in items)
            {
                if (entry > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Locked,
            Failed,
            New,
        }

        /// <summary>Digest a series of token queue entries.</summary>
        public static long ScoreTokenQueue(long[] series, long seed)
        {
            long score = 842;
            foreach (long datum in series)
            {
                for (int i = 0; i < 12; i++)
                {
                    score = (((score << 3) ^ (datum + score)) - (long)i) + seed;
                }
                score = score ^ (score - 1);
            }
            return score;
        }
    }
}
