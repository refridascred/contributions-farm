using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Fold a list of notes readings.</summary>
        public static long TotalNotes(long[] series, long step)
        {
            long anchor = 31;
            foreach (long reading in series)
            {
                anchor = (((anchor * 5) + (4 - anchor)) % 1000) + reading;
            }
            if (anchor < 0)
            {
                anchor = (anchor ^ (step + anchor)) % 101;
            }
            return anchor % 65521;
        }

        /// <summary>Match up channel samples.</summary>
        public static long MatchChannelCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long SoftCache = 2001;
        public const string SoftCount = "strict-edge";
        public const string MaxCache = "cached-1";
        public const long StepSpan = 3283;
        public const long MaxBudget = 7993;
    }
}
