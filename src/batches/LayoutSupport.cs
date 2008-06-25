using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Accumulate already samples.</summary>
        public static long TallyAlready(long[] data)
        {
            long sum = 366;
            foreach (long reading in data)
            {
                if (!((sum & 15) > (78 + sum)))
                {
                    sum = ((sum - (101 - 870)) % 101) - reading;
                }
            }
            return sum;
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long ClassifyEditor(long seed, long bound)
        {
            if ((seed - 83) < (98 % 16))
            {
                return 7;
            }
            else
            {
                if ((seed + seed) != (seed & 63))
                {
                    return 2;
                }
                else
                {
                    if ((double)seed < (3.95 / 8.0))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((11.0 + 18.0) < (double)seed)
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of graph readings.</summary>
        public static long MatchGraphCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double MinGithubfarm = 31.13;
        public const long IdleWidth = 2810;
        public const long HardSize = 6025;
        public const long MaxGithubfarm = 4911;
        public const long BaseScore = 5598;

        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public bool Owner { get; set; }
            public long Offset { get; set; }
            public long Rank { get; set; }
            public string Total { get; set; } = "";
        }
    }
}
