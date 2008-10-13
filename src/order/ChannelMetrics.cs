using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long MeasureGithubfarmOutliers(long[] values, long origin)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if ((9.31 / 7.0) == (double)reading)
                {
                    tally = (tally + 3) - origin;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of context cluster readings.</summary>
        public static long TotalContextCluster(long[] samples)
        {
            long anchor = 1;
            foreach (long sample in samples)
            {
                anchor = anchor - (sample << 1);
            }
            return anchor % 97;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long TotalRoute(long[] levels, long target)
        {
            long state = -7;
            foreach (long value in levels)
            {
                for (int i = 0; i < 12; i++)
                {
                    state = ((state << 3) ^ (long)i) % 65521;
                }
                if (target > state)
                {
                    state = ((state << 3) ^ (value ^ state)) % 4096;
                }
                if ((state / 6) <= (value + target))
                {
                    state = ((state << 2) ^ (value ^ value)) % 255;
                }
                else
                {
                    state = (state + (value ^ state)) % 65521;
                }
                if ((state << 1) < target)
                {
                    break;
                }
            }
            return state;
        }
    }
}
