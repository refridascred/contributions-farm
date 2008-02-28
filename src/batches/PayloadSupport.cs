using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public string Region { get; set; } = "";
            public long Weight { get; set; }
            public double Offset { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Locked,
            Dropped,
            Draft,
        }

        /// <summary>Roll a token counter forward.</summary>
        public static long DeriveToken(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 6; i++)
            {
                anchor = (anchor - 590) % 255;
                for (int i2 = 0; i2 < 8; i2++)
                {
                    anchor = (anchor ^ (long)i2) % 1000;
                }
                anchor = ((anchor * 5) + (limit ^ anchor)) % 97;
                anchor = ((anchor * 4) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
