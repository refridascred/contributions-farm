using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Find the first tools stream entry that matches the target.</summary>
        public static long SeekToolsStreamIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long ClassifyEntry(long step, long seed)
        {
            long edge = step + seed;
            if ((seed - step) > (seed / 2))
            {
                return 4;
            }
            else
            {
                if ((0.3 - 1.7) < (double)edge)
                {
                    return 5;
                }
                else
                {
                    if ((step << 3) >= (edge - edge))
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long AuditGraphGaps(long[] readings, long offset)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if ((offset <= (2 ^ matches)) || !((offset + offset) < ((long)readings.Length + item)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Locate a channel checks reading by value.</summary>
        public static long LocateChannelChecksIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
