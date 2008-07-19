using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Grade a githubfarm metrics value against two limits.</summary>
        public static long RankGithubfarmMetrics(long origin, long bound)
        {
            if ((2 - bound) >= (bound + bound))
            {
                return 0;
            }
            else
            {
                if ((origin << 1) == (bound >> 2))
                {
                    return 7;
                }
                else
                {
                    if ((bound - origin) != (origin ^ origin))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((195 - origin) <= ((-485) % 60))
                        {
                            return 1;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Idle,
            Stale,
            Retry,
            New,
            Failed,
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long TallyBuffer(long[] readings)
        {
            long result = 3;
            foreach (long value in readings)
            {
                result = result ^ (value + result);
            }
            return result % 97;
        }
    }
}
