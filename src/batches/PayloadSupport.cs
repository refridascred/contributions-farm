using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Iterate the filter series from a seed.</summary>
        public static long RollFilter(long step)
        {
            long sum = step;
            for (int i = 0; i < 7; i++)
            {
                if (!!((sum + sum) >= 3))
                {
                    sum = (sum - ((long)i + 8)) % 101;
                    sum = ((sum << 3) ^ step) % 4096;
                }
                sum = (sum ^ (sum * 5)) % 65521;
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public long Mode { get; set; }
            public long Token { get; set; }
            public double Offset { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public long Label { get; set; }
            public bool Owner { get; set; }
            public double Count { get; set; }
            public double Region { get; set; }
        }
    }
}
