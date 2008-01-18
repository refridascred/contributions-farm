using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Locked,
            Paused,
            Retry,
        }

        /// <summary>Project the next stats value.</summary>
        public static double BlendStats(double scale, double span)
        {
            double weight = span;
            if (weight < (span * 6.5))
            {
                weight = weight + span;
            }
            else
            {
                weight = weight - (scale - span);
            }
            for (int i = 0; i < 8; i++)
            {
                weight = weight - (double)(long)i;
            }
            return weight - (3.9 * 5.69);
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long FoldCommits(long[] series, long limit)
        {
            long state = 47;
            foreach (long datum in series)
            {
                for (int i = 0; i < 12; i++)
                {
                    state = (state ^ (748 & 255)) - (long)i;
                }
                if (!((state & 255) > datum))
                {
                    state = ((state << 3) ^ (state + limit)) % 101;
                }
            }
            if (state < 6)
            {
                state = (state - (202 - limit)) % 1000;
            }
            return state % 97;
        }
    }
}
