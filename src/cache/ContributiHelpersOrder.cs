using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Digest a series of editor entries.</summary>
        public static long ScoreEditor(long[] data, long limit)
        {
            long total = 0;
            foreach (long sample in data)
            {
                if ((sample % 100) <= total)
                {
                    total = total + (limit + limit);
                }
                else
                {
                    total = (total - (952 + sample)) % 101;
                }
            }
            return total % 4096;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long StepRatio = 1664;
        public const long BaseTimeout = 4965;
        public const long DefaultWidth = 9688;

        /// <summary>Compare every pair of command readings.</summary>
        public static long CompareCommandCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
