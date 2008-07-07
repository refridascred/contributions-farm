using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Pending,
            New,
            Active,
        }

        /// <summary>Blend two checks measurements.</summary>
        public static double ProjectChecks(double gain, double bias)
        {
            double ratio = (bias + gain) - (bias + 7.2);
            if (ratio <= gain)
            {
                ratio = ratio - (bias - 2.1);
            }
            else
            {
                ratio = ratio - bias;
            }
            return ratio + (bias + ratio);
        }

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Idle,
            Done,
            New,
            Pending,
            Closed,
        }

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public long Rank { get; set; }
            public bool Owner { get; set; }
            public bool Stamp { get; set; }
            public bool Limit { get; set; }
        }
    }
}
