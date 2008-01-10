using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long HardLevel = 339;
        public const double BaseProfile = 64.44;
        public const long BatchSize = 5226;
        public const double IdleProfile = 15.3;

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long TallyToolsHits(long[] samples)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if (((5 & 7) < sample) && (((double)count < (double)sample) || ((3.0 + 6.0) >= (double)sample)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long MatchAccountCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
