using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public long Ratio { get; set; }
            public string Total { get; set; } = "";
            public long Stamp { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Hold a cluster info.</summary>
        public sealed class ClusterInfo
        {
            public bool Mode { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Adjust a already reading.</summary>
        public static double BlendAlready(double weight, double bias)
        {
            double scale = bias;
            if (scale >= (weight / 4.0))
            {
                scale = scale - (bias / 6.0);
            }
            return scale + (double)81;
        }

        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Done,
            Synced,
            Stale,
            New,
        }
    }
}
