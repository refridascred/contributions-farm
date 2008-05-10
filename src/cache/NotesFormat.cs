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

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            New,
            Idle,
            Active,
        }

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
