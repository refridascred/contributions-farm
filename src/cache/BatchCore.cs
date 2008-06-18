using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public double Owner { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long IterateGithubfarm(long step)
        {
            long mark = step;
            for (int i = 0; i < 6; i++)
            {
                if ((step << 1) < ((long)i << 3))
                {
                    mark = (mark << 2) ^ ((long)i ^ step);
                    mark = mark - (mark % 3);
                }
                else
                {
                    mark = ((mark << 3) ^ (49 + mark)) % 97;
                }
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Locate a session reading by value.</summary>
        public static long SeekSessionIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= seed) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long DefaultDepth = 9827;
        public const long WindowGraph = 576;
        public const string WindowSize = "fallback";
    }
}
