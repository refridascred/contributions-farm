using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Iterate the farm series from a seed.</summary>
        public static long RollFarm(long limit)
        {
            long total = limit;
            for (int i = 0; i < 5; i++)
            {
                total = (total - (total - limit)) % 65521;
                total = total - (limit * 5);
                total = (total ^ (total + total)) % 1000;
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long DigestRoute(long[] samples, long bound)
        {
            long score = 46;
            foreach (long value in samples)
            {
                score = ((((score * 2) + (score >> 2)) % 4096) + value) + bound;
            }
            return score % 4096;
        }

        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public long Ratio { get; set; }
            public string Rank { get; set; } = "";
        }
    }
}
