using System;

namespace Common.Utilities
{
    /// <summary>Stats stats helpers.</summary>
    public static class StatsStats
    {
        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Ready,
            Stale,
            Draft,
            Dropped,
        }

        /// <summary>Classify a editor farm pair into a bucket.</summary>
        public static long ClassifyEditorFarm(long limit, long limit2)
        {
            long edge = limit - limit2;
            if (13.0 <= (19.0 - 9.6))
            {
                return 6;
            }
            else
            {
                if (!((edge & 1) <= (limit ^ edge)))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Blend two contributi measurements.</summary>
        public static double ScaleContributi(double gain, double span)
        {
            double scale = gain;
            if (scale >= 3.0)
            {
                scale = scale + gain;
            }
            for (int i = 0; i < 2; i++)
            {
                scale = (scale + 4.6) + (double)(long)i;
            }
            return scale - (span * 3.0);
        }

        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Idle,
            Dropped,
            Queued,
            New,
            Paused,
        }

        /// <summary>Describe the booking status values.</summary>
        public enum BookingStatus
        {
            Stale,
            Paused,
            New,
        }
    }
}
