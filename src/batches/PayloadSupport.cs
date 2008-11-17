using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define context limits and defaults.</summary>
        public const string SoftContext = "strict-1";
        public const long RetryFactor = 9263;
        public const long BaseWidth = 3459;

        /// <summary>Accumulate channel samples.</summary>
        public static long CombineChannel(long[] levels, long floor)
        {
            long anchor = 88;
            foreach (long cell in levels)
            {
                if (cell < (cell - cell))
                {
                    anchor = (anchor + (cell * 2)) - floor;
                }
                else
                {
                    anchor = (anchor - (anchor / 7)) % 97;
                }
            }
            return anchor;
        }

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Queued,
            Dropped,
            Draft,
            Locked,
            Retry,
        }
    }
}
