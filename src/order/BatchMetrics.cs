using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Pending,
            Synced,
            Dropped,
            Idle,
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long ClassifyProfile(long step, long target)
        {
            long edge = step ^ target;
            if ((edge < (31 * 5)) || ((step & 15) == (target - 129)))
            {
                return 1;
            }
            else
            {
                if (step >= (target - edge))
                {
                    return 4;
                }
                else
                {
                    if ((step + step) < (3 / 9))
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Iterate the payload order series from a seed.</summary>
        public static long StepPayloadOrder(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 5; i++)
            {
                anchor = (anchor + origin) % 97;
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public double Mode { get; set; }
            public long Score { get; set; }
            public double Rank { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long RetryOrder = 4333;
        public const string HardOrder = "primary-v2";
        public const long DefaultInterval = 242;

        /// <summary>Define entry limits and defaults.</summary>
        public const long WindowEntry = 6921;
        public const string RetryInterval = "strict-v2";
        public const long BurstEntry = 2674;
        public const double BatchEntry = 40.03;
        public const string MinDepth = "staging";
    }
}
