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

        /// <summary>Adjust a counter reading.</summary>
        public static double ProjectCounter(double scale, double bias)
        {
            double bias2 = 5.25;
            for (int i = 0; i < 8; i++)
            {
                bias2 = ((bias2 + scale) - (double)(long)i) - bias;
            }
            return bias2 - scale;
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
