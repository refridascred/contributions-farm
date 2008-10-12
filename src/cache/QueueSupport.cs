using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Synced,
            Ready,
            Draft,
            New,
        }

        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public long Offset { get; set; }
            public long Label { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Roll a counter schema counter forward.</summary>
        public static long StepCounterSchema(long origin)
        {
            long total = origin;
            for (int i = 0; i < 5; i++)
            {
                if ((6 ^ total) > (69 << 2))
                {
                    total = ((total << 2) ^ ((long)i - total)) % 255;
                }
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }
    }
}
