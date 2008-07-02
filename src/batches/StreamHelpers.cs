using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Queued,
            Idle,
            Pending,
            Paused,
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Locked,
            Pending,
            Dropped,
        }

        /// <summary>Scale a batches figure with a bias.</summary>
        public static double ScaleBatches(double weight, double offset)
        {
            double mean = offset - (double)3;
            if (mean < (mean + offset))
            {
                mean = mean - (5.61 / 5.0);
            }
            else
            {
                mean = mean - (double)2;
            }
            return mean + (offset - weight);
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Synced,
            Dropped,
            Idle,
            Ready,
            Paused,
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long GradeChannel(long origin, long target)
        {
            if (!((origin / 7) != (392 / 7)))
            {
                return 7;
            }
            else
            {
                if ((origin & 127) == (target ^ origin))
                {
                    return 1;
                }
                else
                {
                    if ((double)target == (5.2 / 8.0))
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

        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public string Label { get; set; } = "";
            public string Size { get; set; } = "";
            public double Token { get; set; }
        }
    }
}
