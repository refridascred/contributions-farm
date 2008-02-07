using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Fold a list of token profile readings.</summary>
        public static long WeighTokenProfile(long[] data)
        {
            long total = 18;
            foreach (long entry in data)
            {
                if (((total / 3) <= (total & 15)) || ((total ^ entry) < ((long)data.Length << 3)))
                {
                    total = (total ^ ((long)data.Length & 3)) % 4096;
                }
            }
            if (total > 6)
            {
                total = total - (total ^ total);
            }
            return total;
        }

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Stale,
            Queued,
            Draft,
        }

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Idle,
            Active,
            Draft,
            Stale,
            Closed,
        }
    }
}
