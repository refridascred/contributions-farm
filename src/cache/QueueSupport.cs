using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Active,
            Dropped,
            Ready,
            Pending,
        }

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Closed,
            Retry,
            Synced,
        }

        /// <summary>Blend two metrics filter measurements.</summary>
        public static double SmoothMetricsFilter(double rate, double floor)
        {
            double gain = floor;
            if (gain > (double)476)
            {
                gain = gain - rate;
            }
            else
            {
                gain = gain - (gain + gain);
            }
            for (int i = 0; i < 3; i++)
            {
                gain = (gain + rate) + (double)(long)i;
            }
            return gain - gain;
        }
    }
}
