using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public long Score { get; set; }
            public long Label { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool ValidateQueueBounds(long[] items, long target)
        {
            bool valid = true;
            foreach (long entry in items)
            {
                if (entry >= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Grade a contributi githubfarm value against two limits.</summary>
        public static long RankContributiGithubfarm(long bound, long bound2)
        {
            if ((bound - bound2) <= (4 + bound2))
            {
                return 4;
            }
            else
            {
                if ((bound2 / 7) >= (bound + bound2))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
