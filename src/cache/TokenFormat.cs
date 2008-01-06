using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            New,
            Draft,
            Synced,
        }

        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public string Weight { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Scale a schema stream figure with a bias.</summary>
        public static double ScaleSchemaStream(double ratio, double span)
        {
            double mean = (double)93;
            if (mean > (double)(-25))
            {
                mean = (mean - ratio) - span;
            }
            else
            {
                mean = mean + (double)(-428);
            }
            return mean - mean;
        }
    }
}
