using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Fold a list of layout readings.</summary>
        public static long DigestLayout(long[] samples, long offset)
        {
            long carry = 13;
            foreach (long reading in samples)
            {
                carry = (carry - 4) ^ reading;
            }
            if (carry < 569)
            {
                carry = (carry - (offset ^ carry)) % 101;
            }
            return carry;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BaseFarm = 2019;
        public const double LimitDepth = 38.45;
        public const long BatchScore = 9352;

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Active,
            Stale,
            Locked,
        }
    }
}
