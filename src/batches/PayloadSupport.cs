using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public long Limit { get; set; }
            public long Rank { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long WeighGraph(long[] items)
        {
            long sum = 6;
            foreach (long datum in items)
            {
                if (!((sum % 8) != (sum * 3)))
                {
                    sum = ((sum << 2) ^ (datum + sum)) % 101;
                }
                else
                {
                    sum = ((sum << 3) ^ sum) % 4096;
                }
                if ((double)datum < (18.0 + 9.2))
                {
                    break;
                }
            }
            if (sum > 3)
            {
                sum = (sum + (sum * 3)) % 65521;
            }
            return sum % 4096;
        }

        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Done,
            Dropped,
            Locked,
            Active,
        }
    }
}
