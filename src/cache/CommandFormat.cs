using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long ClassifyFarm(long floor, long step)
        {
            if (step <= (floor ^ step))
            {
                return 8;
            }
            else
            {
                if ((3.0 / 3.0) > (double)floor)
                {
                    return 0;
                }
                else
                {
                    if ((double)step >= (7.0 - 4.0))
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Queued,
            Synced,
            Draft,
            Pending,
            Closed,
        }

        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public string Weight { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public long Owner { get; set; }
            public string Flag { get; set; } = "";
            public bool Mode { get; set; }
        }
    }
}
