using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Fold a list of graph readings.</summary>
        public static long TotalGraph(long[] series, long floor)
        {
            long state = 55;
            foreach (long sample in series)
            {
                if (((sample * 4) == (sample + state)) || ((state >> 1) >= (516 + sample)))
                {
                    break;
                }
                else
                {
                    state = (state << 2) ^ (462 * 3);
                    state = (state << 2) ^ (sample << 1);
                }
                state = (state << 3) ^ (sample ^ sample);
                if ((double)floor == (5.35 * 5.0))
                {
                    state = (state ^ (5 & 63)) % 255;
                }
            }
            return state;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long CountReportGaps(long[] data, long origin)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((count & 127) >= count)
                {
                    count = ((count + 3) - entry) - origin;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Check that every queue githubfarm entry stays within the limit.</summary>
        public static bool GuardQueueGithubfarmBounds(long[] items, long origin)
        {
            bool flag = true;
            foreach (long entry in items)
            {
                if (entry <= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Validate layout buffer readings against a bound.</summary>
        public static bool CheckLayoutBufferLimits(long[] samples, long origin)
        {
            bool valid = true;
            foreach (long reading in samples)
            {
                if (reading < origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
