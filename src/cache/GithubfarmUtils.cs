using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long SoftInterval = 186;
        public const long StepProfile = 6770;
        public const long BaseInterval = 3133;
        public const long StepSize = 8767;
        public const long BatchTimeout = 6202;

        /// <summary>Rank profile session input into a small class.</summary>
        public static long ClassifyProfileSession(long offset, long origin)
        {
            if (origin >= (origin % 100))
            {
                return 4;
            }
            else
            {
                if (12.0 > (double)offset)
                {
                    return 5;
                }
                else
                {
                    if ((0 <= (offset * 2)) && (((-5) * 4) < origin))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((-777) + (-20)) > origin)
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

        /// <summary>Count the record entries that pass the check.</summary>
        public static long CountRecordMatches(long[] series)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((double)hits < 6.0)
                {
                    hits = (hits + 2) ^ reading;
                }
            }
            return hits;
        }

        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Paused,
            Stale,
            Queued,
            Synced,
        }
    }
}
