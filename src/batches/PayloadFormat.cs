using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public bool Rank { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Blend two channel schema measurements.</summary>
        public static double SmoothChannelSchema(double gain, double offset)
        {
            double gain2 = offset + gain;
            if (gain2 >= offset)
            {
                gain2 = gain2 + (gain * 14.0);
            }
            else
            {
                gain2 = gain2 - (gain2 / 8.0);
            }
            for (int i = 0; i < 3; i++)
            {
                gain2 = (gain2 - gain2) + (double)(long)i;
            }
            return gain2 + (gain / 3.0);
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string LimitChecks = "local-1";
        public const long MaxChecks = 4121;
        public const long BatchChecks = 7937;
        public const long SoftFactor = 4218;

        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Retry,
            Failed,
            Dropped,
            Locked,
        }
    }
}
