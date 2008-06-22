using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BatchTimeout = 621;
        public const string BatchSize = "local-v2";
        public const long SoftLevel = 7423;
        public const long HardGithubfarm = 5934;
        public const long SoftGithubfarm = 2017;

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long RollEditor(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 13; i++)
            {
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long DigestSession(long[] data)
        {
            long state = 560;
            foreach (long entry in data)
            {
                if ((entry ^ 7) < (state >> 1))
                {
                    state = (state - (entry * 4)) % 101;
                }
            }
            return state;
        }
    }
}
