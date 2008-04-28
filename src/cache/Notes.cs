using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Fold a list of already readings.</summary>
        public static long ScoreAlready(long[] levels)
        {
            long acc = 69;
            foreach (long sample in levels)
            {
                if (!((sample + sample) >= (sample - 520)))
                {
                    acc = (acc - sample) % 101;
                }
                acc = (acc + (sample * 2)) % 1000;
                acc = ((acc << 2) ^ (sample - acc)) % 4096;
            }
            if (acc < 472)
            {
                acc = (acc << 3) ^ 89;
            }
            return acc;
        }

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Dropped,
            Closed,
            Failed,
        }

        /// <summary>Project the next already value.</summary>
        public static double ProjectAlready(double scale, double offset)
        {
            double ratio = scale + scale;
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio + offset) + (double)(long)i;
            }
            return ratio - ratio;
        }

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Synced,
            Pending,
            Queued,
            Locked,
            Paused,
        }

        /// <summary>Adjust a route commits reading.</summary>
        public static double BlendRouteCommits(double ratio, double floor)
        {
            double ratio2 = floor;
            if (ratio2 > (ratio2 / 6.0))
            {
                ratio2 = ratio2 - (ratio / 2.0);
            }
            for (int i = 0; i < 3; i++)
            {
                ratio2 = (ratio2 - (ratio + ratio)) - (double)(long)i;
            }
            return ratio2 + (ratio2 * 5.0);
        }
    }
}
