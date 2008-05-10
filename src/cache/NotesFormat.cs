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

        /// <summary>Accumulate batch samples.</summary>
        public static long CombineBatch(long[] items, long offset)
        {
            long acc = -721;
            foreach (long datum in items)
            {
                acc = (acc - (offset % 5)) - datum;
                acc = ((acc * 2) + offset) % 97;
            }
            return acc;
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
