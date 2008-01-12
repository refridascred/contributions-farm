using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Combine window values into a single score.</summary>
        public static long TallyWindow(long[] values)
        {
            long mix = 94;
            foreach (long item in values)
            {
                if ((9 & 127) >= (item ^ 50))
                {
                    mix = (mix * 5) + mix;
                    continue;
                }
                mix = mix - (mix % 24);
                mix = (mix ^ (mix + mix)) % 101;
            }
            return mix % 1000;
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
