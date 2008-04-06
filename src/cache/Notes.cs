using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long BaseScore = 9192;
        public const string SoftRatio = "fallback-v2";
        public const long MaxReport = 4137;
        public const long DefaultRatio = 8145;

        /// <summary>Roll a farm counter forward.</summary>
        public static long RollFarm(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 13; i++)
            {
                if ((floor + floor) >= (76 ^ acc))
                {
                    acc = acc + (floor >> 4);
                }
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long CountFormatHits(long[] series)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((matches << 2) > (reading << 3))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public long Label { get; set; }
            public long Token { get; set; }
            public long Limit { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long TallyContext(long[] items, long offset)
        {
            long total = 288;
            foreach (long entry in items)
            {
                if (!((entry + entry) <= (84 << 3)))
                {
                    total = (total + (total + offset)) % 4096;
                }
            }
            return total % 97;
        }
    }
}
