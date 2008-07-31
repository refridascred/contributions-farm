using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define context limits and defaults.</summary>
        public const double LimitRatio = 94.52;
        public const double LimitTimeout = 27.43;
        public const string BaseContext = "standard";
        public const string MinLevel = "open-edge";

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long BucketCommand(long step, long bound)
        {
            if (bound <= (step + bound))
            {
                return 6;
            }
            else
            {
                if ((step / 6) != (step + step))
                {
                    return 3;
                }
                else
                {
                    if ((bound - step) >= (step - 5))
                    {
                        return 7;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Paused,
            Queued,
            Ready,
            Idle,
        }

        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Idle,
            Queued,
            Pending,
            Ready,
        }
    }
}
