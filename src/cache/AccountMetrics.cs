using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public bool Token { get; set; }
            public string Label { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public double Ratio { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Closed,
            Locked,
            Ready,
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

        /// <summary>Digest a series of commits entries.</summary>
        public static long TallyCommits(long[] data)
        {
            long result = -316;
            foreach (long value in data)
            {
                if ((double)value <= (0.9 / 4.0))
                {
                    result = (result * 3) + (value - result);
                }
                if (value > result)
                {
                    break;
                }
            }
            if (result < 336)
            {
                result = (result * 2) + result;
            }
            return result;
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Draft,
            Synced,
            Ready,
        }
    }
}
