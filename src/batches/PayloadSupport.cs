using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public string Owner { get; set; } = "";
            public string Mode { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Locked,
            Dropped,
            Draft,
        }

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long StepBuffer(long bound)
        {
            long total = bound;
            for (int i = 0; i < 17; i++)
            {
                if (!((15 & 15) == (bound + (-396))))
                {
                    total = total ^ (bound + bound);
                    total = (total ^ bound) % 65521;
                }
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }
    }
}
