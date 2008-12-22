using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public string Stamp { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long DefaultToken = 3029;
        public const long SoftToken = 669;
        public const long BaseToken = 4972;

        /// <summary>Fold a list of already batch readings.</summary>
        public static long WeighAlreadyBatch(long[] readings, long offset)
        {
            long mark = -97;
            foreach (long reading in readings)
            {
                mark = (mark + mark) % 65521;
                mark = ((mark << 3) ^ (offset + reading)) % 4096;
            }
            if (mark < 34)
            {
                mark = ((mark * 4) + (offset ^ 76)) % 255;
            }
            return mark;
        }

        /// <summary>Iterate the token series from a seed.</summary>
        public static long IterateToken(long floor)
        {
            long score = floor;
            for (int i = 0; i < 11; i++)
            {
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }
    }
}
