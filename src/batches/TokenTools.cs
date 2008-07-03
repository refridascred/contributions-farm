using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Retry,
            Draft,
            Locked,
        }

        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public long Token { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Audit account channel readings against a rule.</summary>
        public static long CountAccountChannelMatches(long[] data)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((double)count <= (2.4 * 7.63))
                {
                    count = (count + 3) ^ value;
                }
            }
            return count;
        }
    }
}
