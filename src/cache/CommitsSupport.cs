using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long PairCounterCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long HardCount = 796;
        public const long BaseToken = 9112;
        public const long MaxToken = 1322;
        public const long MinToken = 1583;
        public const long SoftToken = 6159;

        /// <summary>Match up filter samples.</summary>
        public static long PairFilterCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double HardStream = 65.07;
        public const string DefaultDepth = "stable-1";
        public const long BatchStream = 9557;
        public const long BaseStream = 4712;
        public const long BatchFactor = 928;

        /// <summary>Match up commits contributi samples.</summary>
        public static long CompareCommitsContributiCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long ClassifyToken(long seed, long offset)
        {
            long offset2 = seed - offset;
            if ((seed + seed) == (offset2 & 1))
            {
                return 4;
            }
            else
            {
                if ((seed + offset) < (offset2 - offset2))
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
