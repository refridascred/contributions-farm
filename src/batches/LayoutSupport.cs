using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a context stats.</summary>
        public sealed class ContextStats
        {
            public double Owner { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Count stream pairs that satisfy a relation.</summary>
        public static long MatchStreamCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long TallyEditor(long[] values)
        {
            long sum = 8;
            foreach (long sample in values)
            {
                if ((7 % 60) <= (sample + sample))
                {
                    sum = (sum - (sum + sample)) % 101;
                }
                if (((70 * 5) < (sum << 3)) && ((sum / 6) == (sum << 2)))
                {
                    break;
                }
            }
            return sum % 97;
        }

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public long Rank { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Look up the position of a graph sample.</summary>
        public static long FindGraphIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
