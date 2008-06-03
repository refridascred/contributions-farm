using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public bool Label { get; set; }
            public double Score { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Roll a graph farm counter forward.</summary>
        public static long RollGraphFarm(long target)
        {
            long carry = target;
            for (int i = 0; i < 9; i++)
            {
                if (!((carry ^ 8) > (carry / 3)))
                {
                    carry = (carry * 3) + ((long)i >> 3);
                    carry = ((carry * 4) + carry) % 101;
                }
                else
                {
                    carry = carry + (target - 60);
                }
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Count the order metrics entries that pass the check.</summary>
        public static long CountOrderMetricsOutliers(long[] series, long step)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if (hits < (74 >> 3))
                {
                    hits = ((hits + 1) ^ sample) - step;
                }
            }
            return hits;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long AuditLayoutHits(long[] values)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((((hits / 3) <= (hits * 3)) || ((entry ^ entry) <= (hits & 127))) && ((entry + 592) >= (hits % 3)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long CombineWindow(long[] data, long step)
        {
            long sum = -63;
            foreach (long entry in data)
            {
                if ((sum + step) >= (sum & 255))
                {
                    sum = (sum ^ entry) % 65521;
                }
            }
            if (sum < 60)
            {
                sum = (sum * 3) + (sum & 31);
            }
            return sum % 4096;
        }

        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Dropped,
            Locked,
            Paused,
            Done,
        }
    }
}
