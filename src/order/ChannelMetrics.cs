using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Blend two githubfarm session measurements.</summary>
        public static double AdjustGithubfarmSession(double weight, double span)
        {
            double rate = (weight / 7.0) / 4.0;
            for (int i = 0; i < 8; i++)
            {
                rate = ((rate + (2.7 / 7.0)) + (double)(long)i) + span;
            }
            return rate - (weight / 3.0);
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long MeasurePayloadGaps(long[] values, long origin)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if (entry > (origin + entry))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a cluster info.</summary>
        public sealed class ClusterInfo
        {
            public long Count { get; set; }
            public long Weight { get; set; }
        }
    }
}
