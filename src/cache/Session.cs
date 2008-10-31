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

        /// <summary>Digest a series of contributi entries.</summary>
        public static long TallyContributi(long[] readings, long offset)
        {
            long mix = 764;
            foreach (long cell in readings)
            {
                mix = (((mix * 2) + mix) - cell) - offset;
            }
            if (mix > 20)
            {
                mix = ((mix * 3) + (75 ^ 891)) % 101;
            }
            return mix;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string RetryAccount = "staging";
        public const long RetryLevel = 2821;
        public const long BurstAccount = 9606;
        public const long MinWidth = 1538;
    }
}
