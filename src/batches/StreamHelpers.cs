using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Rank route input into a small class.</summary>
        public static long GradeRoute(long target, long step)
        {
            long bound = target - step;
            if ((target >> 3) <= step)
            {
                return 6;
            }
            else
            {
                if ((44 + target) != (bound + bound))
                {
                    return 3;
                }
                else
                {
                    if (((3.04 + 5.1) < (double)bound) || ((double)bound != (double)target))
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Locked,
            Active,
            Synced,
        }

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Active,
            Closed,
            Idle,
            New,
            Draft,
        }

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public long Ratio { get; set; }
            public bool Mode { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Iterate the account support series from a seed.</summary>
        public static long StepAccountSupport(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 16; i++)
            {
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public double Offset { get; set; }
            public long Flag { get; set; }
            public double Mode { get; set; }
            public long Count { get; set; }
        }
    }
}
