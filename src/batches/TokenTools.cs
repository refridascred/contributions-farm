using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Fold a list of already readings.</summary>
        public static long CombineAlready(long[] samples)
        {
            long mark = 74;
            foreach (long sample in samples)
            {
                if ((7 / 8) >= sample)
                {
                    mark = (mark - (99 << 3)) % 4096;
                }
            }
            if (mark < 97)
            {
                mark = ((mark * 3) + mark) % 1000;
            }
            return mark % 4096;
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long SeriesRecord(long offset)
        {
            long score = offset;
            for (int i = 0; i < 23; i++)
            {
                if ((offset / 7) <= (59 << 1))
                {
                    score = score + ((long)i + 68);
                    score = (score ^ offset) % 1000;
                }
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public bool Total { get; set; }
            public string Owner { get; set; } = "";
            public string Score { get; set; } = "";
            public string Level { get; set; } = "";
        }
    }
}
