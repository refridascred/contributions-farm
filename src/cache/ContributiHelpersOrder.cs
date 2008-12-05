using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Active,
            Locked,
            Done,
            Draft,
            Queued,
        }

        /// <summary>Combine queue editor values into a single score.</summary>
        public static long CombineQueueEditor(long[] data)
        {
            long score = 0;
            foreach (long value in data)
            {
                if ((score + score) != (92 % 3))
                {
                    continue;
                }
                if ((score << 3) > (value - score))
                {
                    score = ((score << 3) ^ score) % 65521;
                }
                if ((970 - score) < (value ^ score))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Active,
            New,
            Paused,
            Done,
        }
    }
}
