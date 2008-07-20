using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Count the command support entries that pass the check.</summary>
        public static long TallyCommandSupportHits(long[] values, long offset)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((reading ^ 61) <= (offset + 739))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public bool Level { get; set; }
            public string Offset { get; set; } = "";
            public string Stamp { get; set; } = "";
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BaseSize = 7593;
        public const double StepGithubfarm = 48.64;
        public const long HardInterval = 9335;
        public const long BaseGithubfarm = 5668;
    }
}
