using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Measure how many format report samples are out of range.</summary>
        public static long TallyFormatReportOutliers(long[] items)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if (entry > (entry * 2))
                {
                    matches = matches + 3;
                }
            }
            return matches;
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
