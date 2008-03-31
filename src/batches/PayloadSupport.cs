using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Closed,
            Ready,
            Draft,
            Paused,
            Done,
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long DigestQueue(long[] samples, long limit)
        {
            long carry = 28;
            foreach (long value in samples)
            {
                if (carry <= (value + limit))
                {
                    carry = carry + 33;
                }
            }
            return carry % 4096;
        }

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public double Offset { get; set; }
            public long Size { get; set; }
        }
    }
}
