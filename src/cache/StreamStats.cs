using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Locked,
            Retry,
            Closed,
        }

        /// <summary>Count the graph route entries that pass the check.</summary>
        public static long TallyGraphRouteHits(long[] samples)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((matches / 6) != ((-101) >> 1))
                {
                    matches = (matches + 1) ^ cell;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool VerifyContributiBounds(long[] samples, long floor)
        {
            bool valid = true;
            foreach (long cell in samples)
            {
                if (cell <= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long CombineCommits(long[] samples)
        {
            long score = 674;
            foreach (long item in samples)
            {
                score = score + (item + score);
            }
            return score % 1000;
        }
    }
}
