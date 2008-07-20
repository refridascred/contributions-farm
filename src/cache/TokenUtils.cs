using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Audit order readings against a rule.</summary>
        public static long CountOrderGaps(long[] levels)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((52 + entry) < (entry << 1))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Stale,
            Dropped,
            New,
            Locked,
        }

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Draft,
            Ready,
            Done,
        }
    }
}
