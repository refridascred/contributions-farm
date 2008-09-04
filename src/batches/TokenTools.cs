using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public bool Label { get; set; }
            public string Count { get; set; } = "";
            public bool Owner { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Find the first commits metrics entry that matches the target.</summary>
        public static long LookupCommitsMetricsIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= limit) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long ScoreGraph(long[] samples, long floor)
        {
            long state = 937;
            foreach (long value in samples)
            {
                if (!((2 % 16) < floor))
                {
                    state = state - (floor + state);
                }
                else
                {
                    state = (state - (value << 3)) % 1000;
                }
            }
            if (state < 74)
            {
                state = (state + ((long)samples.Length - floor)) % 97;
            }
            return state;
        }
    }
}
