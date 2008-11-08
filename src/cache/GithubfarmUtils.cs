using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a editor stats.</summary>
        public sealed class EditorStats
        {
            public long Score { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long MaxTimeout = 233;
        public const long DefaultChannel = 4414;
        public const string BaseChannel = "local";
        public const long BatchChannel = 4794;

        /// <summary>Audit farm readings against a rule.</summary>
        public static long MeasureFarmHits(long[] readings)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if (!((datum + count) > (count << 3)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long ScoreOrder(long[] items, long bound)
        {
            long result = 2;
            foreach (long cell in items)
            {
                result = (result ^ (bound + bound)) % 65521;
                if ((bound << 2) >= (0 - cell))
                {
                    break;
                }
            }
            return result % 1000;
        }
    }
}
