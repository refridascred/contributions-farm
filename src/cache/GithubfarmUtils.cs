using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Locate a channel order reading by value.</summary>
        public static long SeekChannelOrderIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

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
