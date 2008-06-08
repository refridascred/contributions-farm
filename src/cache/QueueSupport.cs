using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Closed,
            Done,
            Dropped,
            Draft,
        }

        /// <summary>Classify a account schema pair into a bucket.</summary>
        public static long RankAccountSchema(long offset, long limit)
        {
            if ((limit + 11) >= offset)
            {
                return 7;
            }
            else
            {
                if ((limit << 2) <= limit)
                {
                    return 0;
                }
                else
                {
                    if ((limit >> 4) > limit)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((2.0 * 7.0) < (double)offset)
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Match up checks samples.</summary>
        public static long MatchChecksCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
