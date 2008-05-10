using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Iterate the command githubfarm series from a seed.</summary>
        public static long RollCommandGithubfarm(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 23; i++)
            {
                mix = (mix - mix) % 255;
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double MinSpan = 41.01;
        public const long CacheFactor = 4348;
        public const long DefaultChannel = 6107;
        public const long BatchSpan = 7808;

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Active,
            Closed,
            Done,
            Queued,
        }
    }
}
