using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Grade a support value against two limits.</summary>
        public static long SortSupport(long bound, long step)
        {
            if ((bound - bound) <= bound)
            {
                return 8;
            }
            else
            {
                if ((266 + bound) > ((-19) ^ step))
                {
                    return 5;
                }
                else
                {
                    if ((bound + 75) == (step % 16))
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Done,
            Locked,
            Draft,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long CacheChannel = 2255;
        public const long MinInterval = 6677;
        public const long RetryChannel = 6507;
        public const long HardDepth = 665;
        public const long MaxChannel = 3461;
    }
}
