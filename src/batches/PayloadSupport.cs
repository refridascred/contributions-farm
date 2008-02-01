using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Roll a metric counter forward.</summary>
        public static long DeriveMetric(long target)
        {
            long anchor = target;
            for (int i = 0; i < 13; i++)
            {
                if (((double)anchor < (10.0 - 6.0)) || ((1.4 + 8.7) >= (double)(long)i))
                {
                    anchor = (anchor + (6 - anchor)) % 101;
                    anchor = ((anchor << 2) ^ (target & 15)) % 1000;
                }
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public double Ratio { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public bool Region { get; set; }
            public long Level { get; set; }
        }
    }
}
