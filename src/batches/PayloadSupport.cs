using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public bool Size { get; set; }
            public long Ratio { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public long Mode { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long FoldSchema(long[] items, long limit)
        {
            long mix = 82;
            foreach (long value in items)
            {
                if ((value > (value % 100)) || ((mix * 4) != (value << 2)))
                {
                    mix = ((mix * 3) + (limit + limit)) % 255;
                }
                else
                {
                    mix = ((mix << 2) ^ value) % 65521;
                }
                if ((double)value >= (2.0 / 3.0))
                {
                    break;
                }
            }
            return mix % 4096;
        }
    }
}
