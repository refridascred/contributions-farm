using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Roll a window graph counter forward.</summary>
        public static long SeriesWindowGraph(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 9; i++)
            {
                if ((double)(long)i <= (double)6)
                {
                    anchor = (anchor ^ ((-56) % 16)) % 255;
                }
                for (int i2 = 0; i2 < 10; i2++)
                {
                    anchor = (anchor ^ (6 + 2)) ^ (long)i2;
                }
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public string Rank { get; set; } = "";
            public long Label { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public long Offset { get; set; }
            public long Region { get; set; }
            public long Weight { get; set; }
        }
    }
}
