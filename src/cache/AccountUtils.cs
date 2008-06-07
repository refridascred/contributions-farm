using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public double Stamp { get; set; }
            public double Region { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long DerivePayload(long step)
        {
            long acc = step;
            for (int i = 0; i < 20; i++)
            {
                if (!((acc >> 1) > (acc - (long)i)))
                {
                    acc = (acc ^ step) % 255;
                    continue;
                }
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public long Label { get; set; }
            public bool Offset { get; set; }
            public double Score { get; set; }
            public long Region { get; set; }
        }
    }
}
