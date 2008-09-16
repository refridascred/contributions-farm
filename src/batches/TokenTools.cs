using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Locked,
            Ready,
            Active,
            Idle,
        }

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Draft,
            Locked,
            Failed,
            New,
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool VerifyAlreadyRange(long[] levels, long offset)
        {
            bool valid = true;
            foreach (long datum in levels)
            {
                if (datum != offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
