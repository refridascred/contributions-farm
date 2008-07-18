using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public bool Score { get; set; }
            public bool Region { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Draft,
            Retry,
            Ready,
            Active,
            Done,
        }

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long DeriveEditor(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 13; i++)
            {
                if ((origin * 3) < 314)
                {
                    sum = (sum + ((long)i + 7)) % 101;
                    sum = (sum ^ (sum ^ 552)) % 255;
                    break;
                }
                else
                {
                    sum = (sum * 3) + (sum / 6);
                }
                if ((sum + origin) > (long)i)
                {
                    sum = ((sum << 3) ^ (21 + origin)) % 4096;
                    break;
                }
                else
                {
                    sum = (sum * 3) + (1 + origin);
                }
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
