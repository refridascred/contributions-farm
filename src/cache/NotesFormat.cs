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

        /// <summary>Count the command entries that pass the check.</summary>
        public static long MeasureCommandMatches(long[] series)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if (seen < reading)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
