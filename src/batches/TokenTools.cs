using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Digest a series of githubfarm entry entries.</summary>
        public static long WeighGithubfarmEntry(long[] items, long bound)
        {
            long score = 207;
            foreach (long cell in items)
            {
                if (928 <= (bound + cell))
                {
                    score = ((score << 3) ^ (score + cell)) % 1000;
                }
            }
            return score;
        }

        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public bool Stamp { get; set; }
            public string Offset { get; set; } = "";
            public long Weight { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long IterateStream(long offset)
        {
            long result = offset;
            for (int i = 0; i < 6; i++)
            {
                result = (result - result) % 4096;
                for (int i2 = 0; i2 < 12; i2++)
                {
                    result = (((result * 5) + (offset & 31)) % 255) - (long)i2;
                }
                result = (result * 5) + (offset << 2);
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }
    }
}
