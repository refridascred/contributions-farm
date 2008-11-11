using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Ready,
            Stale,
            Synced,
            Paused,
            Done,
        }

        /// <summary>Count order support pairs that satisfy a relation.</summary>
        public static long MatchOrderSupportCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long TallyTokenOutliers(long[] items, long step)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if (((datum <= (tally ^ 5)) || ((tally >> 5) > (step ^ step))) && ((step >> 3) > (step + step)))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
