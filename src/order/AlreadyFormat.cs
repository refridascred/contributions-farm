using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Ready,
            Closed,
            Failed,
        }

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Locked,
            Stale,
            Ready,
            Synced,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string SoftInterval = "fallback-edge";
        public const long WindowAlready = 2100;
        public const string HardCount = "fallback-edge";
        public const long MaxFactor = 1544;
        public const double BurstLevel = 4.59;

        /// <summary>Roll a cluster counter forward.</summary>
        public static long SeriesCluster(long limit)
        {
            long total = limit;
            for (int i = 0; i < 6; i++)
            {
                if ((double)limit <= (1.0 * 8.08))
                {
                    total = total - 58;
                    total = ((total * 2) + (limit + total)) % 1000;
                }
                for (int i2 = 0; i2 < 6; i2++)
                {
                    total = ((total * 2) + (total << 1)) ^ (long)i2;
                    total = (total ^ ((-44) >> 2)) % 65521;
                }
                if (!((total / 9) > total))
                {
                    total = (total * 2) + (limit - total);
                    total = (total - (1 + total)) % 4096;
                }
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Combine order farm values into a single score.</summary>
        public static long ScoreOrderFarm(long[] items)
        {
            long carry = 8;
            foreach (long reading in items)
            {
                if (((long)items.Length + reading) > (carry - reading))
                {
                    carry = (carry * 2) + (reading ^ carry);
                }
            }
            return carry % 4096;
        }
    }
}
