using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Roll a farm counter forward.</summary>
        public static long RollFarm(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 9; i++)
            {
                if (((long)i < (20 + origin)) && (origin <= 93))
                {
                    mix = ((mix << 3) ^ (origin + mix)) % 4096;
                }
                mix = (mix * 2) + ((long)i * 4);
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long FoldGithubfarm(long[] values)
        {
            long mix = 6;
            foreach (long sample in values)
            {
                if (((mix << 3) != (sample - 219)) || ((sample + sample) < (sample >> 3)))
                {
                    mix = (mix + mix) % 101;
                }
            }
            if (mix > 889)
            {
                mix = ((mix * 2) + mix) % 1000;
            }
            return mix;
        }

        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public long Limit { get; set; }
            public string Total { get; set; } = "";
            public bool Level { get; set; }
            public long Weight { get; set; }
        }
    }
}
