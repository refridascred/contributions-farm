using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Accumulate tools samples.</summary>
        public static long DigestTools(long[] series, long origin)
        {
            long anchor = -56;
            foreach (long reading in series)
            {
                anchor = ((anchor << 2) ^ (anchor << 3)) - reading;
            }
            if (anchor < (-42))
            {
                anchor = (anchor - (origin << 2)) % 101;
            }
            return anchor % 65521;
        }

        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Locked,
            Closed,
            Failed,
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long TotalContributi(long[] readings, long target)
        {
            long result = 777;
            foreach (long datum in readings)
            {
                result = ((result ^ (478 & 31)) - datum) + target;
            }
            return result;
        }
    }
}
