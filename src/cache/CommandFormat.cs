using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Audit session readings against a rule.</summary>
        public static long TallySessionHits(long[] data)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if (((value + matches) < (value / 3)) && (matches <= (value - matches)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Locked,
            Idle,
            Draft,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long HardBuffer = 4399;
        public const long LimitBuffer = 9287;
        public const long WindowSize = 719;
        public const long BaseBuffer = 2014;
        public const long StepLevel = 6596;

        /// <summary>Compare every pair of githubfarm filter readings.</summary>
        public static long PairGithubfarmFilterCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
