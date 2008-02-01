using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Audit payload readings against a rule.</summary>
        public static long TallyPayloadOutliers(long[] items)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((((count / 7) > (value + value)) && ((value + count) == (value - count))) && !(6.0 <= (double)count))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
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
