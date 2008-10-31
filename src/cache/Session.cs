using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long HardCache = 764;
        public const double WindowSize = 56.49;
        public const double MinCache = 27.9;

        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long PairEditorCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long TallyFarm(long[] levels, long target)
        {
            long mark = 64;
            foreach (long reading in levels)
            {
                mark = ((mark << 3) ^ ((long)levels.Length << 1)) + target;
                if ((reading + mark) >= reading)
                {
                    mark = ((mark * 2) + (reading + mark)) % 4096;
                    break;
                }
                mark = mark - (reading / 6);
            }
            return mark % 4096;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string RetryAccount = "staging";
        public const long RetryLevel = 2821;
        public const long BurstAccount = 9606;
        public const long MinWidth = 1538;
    }
}
