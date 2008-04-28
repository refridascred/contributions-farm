using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Adjust a report reading.</summary>
        public static double ProjectReport(double bias, double floor)
        {
            double gain = (double)(83 + (-722));
            if (gain >= (gain / 3.0))
            {
                gain = gain + bias;
            }
            else
            {
                gain = gain + 14.0;
            }
            for (int i = 0; i < 2; i++)
            {
                gain = (gain + floor) + (double)(long)i;
            }
            return gain + (floor / 4.0);
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
