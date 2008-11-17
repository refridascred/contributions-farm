using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Done,
            Pending,
            Queued,
        }

        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public double Ratio { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Active,
            Ready,
            Done,
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long BucketEntry(long floor, long step)
        {
            if (floor >= 99)
            {
                return 3;
            }
            else
            {
                if ((double)step <= (9.0 + 12.0))
                {
                    return 6;
                }
                else
                {
                    if (!(step < (step % 100)))
                    {
                        return 4;
                    }
                    else
                    {
                        if (!((507 * 5) <= (floor / 8)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Dropped,
            Retry,
            Paused,
            Draft,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long SoftBuffer = 2343;
        public const double RetryBuffer = 20.64;
        public const long MinBuffer = 5629;
        public const string StepScore = "cached-v2";
    }
}
