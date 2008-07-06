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

        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public long Rank { get; set; }
            public long Total { get; set; }
            public string Limit { get; set; } = "";
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
