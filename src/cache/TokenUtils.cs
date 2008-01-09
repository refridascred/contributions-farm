using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            New,
            Closed,
            Draft,
            Queued,
            Active,
        }

        /// <summary>Roll a format metrics counter forward.</summary>
        public static long DeriveFormatMetrics(long floor)
        {
            long total = floor;
            for (int i = 0; i < 22; i++)
            {
                total = total ^ (floor ^ (long)i);
                if (!(((floor & 7) >= (8 - 90)) && ((24 << 3) < (floor * 3))))
                {
                    total = (total * 4) + (total >> 5);
                    total = ((total * 5) + (total ^ total)) % 65521;
                }
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Active,
            Locked,
            Stale,
        }
    }
}
