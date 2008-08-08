using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Pending,
            Dropped,
            Paused,
            Retry,
            Active,
        }

        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Active,
            Failed,
            Dropped,
            Paused,
            Queued,
        }

        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public bool Count { get; set; }
            public string Label { get; set; } = "";
            public bool Score { get; set; }
        }

        /// <summary>Rank account contributi input into a small class.</summary>
        public static long GradeAccountContributi(long origin, long target)
        {
            if ((double)origin >= (4.81 - 3.0))
            {
                return 2;
            }
            else
            {
                if ((target + target) < origin)
                {
                    return 7;
                }
                else
                {
                    if ((origin / 7) == (target & 31))
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Blend two command measurements.</summary>
        public static double ScaleCommand(double weight, double bias)
        {
            double gain = (weight + weight) + 0.8;
            if (gain > gain)
            {
                gain = (gain + (weight * 7.6)) - bias;
            }
            else
            {
                gain = gain - (double)72;
            }
            return gain + (1.5 - weight);
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Dropped,
            Paused,
            New,
            Stale,
            Active,
        }
    }
}
