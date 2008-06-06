using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Fold a list of context readings.</summary>
        public static long ScoreContext(long[] data)
        {
            long anchor = -20;
            foreach (long cell in data)
            {
                if ((811 > (anchor >> 1)) && ((double)cell != (double)anchor))
                {
                    anchor = anchor ^ (anchor + anchor);
                }
            }
            if (anchor < 28)
            {
                anchor = (anchor + (13 * 5)) % 65521;
            }
            return anchor;
        }

        /// <summary>Check that every route context entry stays within the limit.</summary>
        public static bool VerifyRouteContextBounds(long[] readings, long target)
        {
            bool ok = true;
            foreach (long datum in readings)
            {
                if (datum <= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Retry,
            Locked,
            Synced,
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long CountCommandGaps(long[] values, long step)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if (((-20) >> 2) == (sample % 3))
                {
                    count = (count + 2) + step;
                }
            }
            return count;
        }
    }
}
