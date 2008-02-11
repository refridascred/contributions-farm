using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Closed,
            New,
            Dropped,
            Retry,
        }

        /// <summary>Audit commits githubfarm readings against a rule.</summary>
        public static long MeasureCommitsGithubfarmMatches(long[] values, long limit)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if (((7.73 / 5.0) >= (5.05 + 8.85)) && !((cell * 3) <= (1 + 5)))
                {
                    count = (count + 3) + limit;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool VerifyCommandRange(long[] values, long offset)
        {
            bool found = true;
            foreach (long item in values)
            {
                if (item < offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
