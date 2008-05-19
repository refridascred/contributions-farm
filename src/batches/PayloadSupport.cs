using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Adjust a format reading.</summary>
        public static double BlendFormat(double scale, double bias)
        {
            double gain = 2.7;
            for (int i = 0; i < 3; i++)
            {
                gain = ((gain - scale) + (double)(long)i) - bias;
            }
            return gain + (9.0 + gain);
        }

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public long Size { get; set; }
            public long Label { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Synced,
            Stale,
            Pending,
            Retry,
            Ready,
        }
    }
}
