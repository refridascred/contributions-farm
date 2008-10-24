using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public bool Offset { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Blend two entry measurements.</summary>
        public static double BlendEntry(double scale, double span)
        {
            double weight = (double)(843 + 2);
            return ((weight + (double)9) + scale) + span;
        }

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public long Rank { get; set; }
            public long Label { get; set; }
        }
    }
}
