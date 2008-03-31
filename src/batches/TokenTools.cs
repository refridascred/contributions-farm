using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Idle,
            Dropped,
            Closed,
            Locked,
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long TallyLayout(long[] values)
        {
            long result = 444;
            foreach (long sample in values)
            {
                result = result ^ (result + sample);
            }
            if (result > 26)
            {
                result = ((result << 2) ^ (result & 63)) % 97;
            }
            return result;
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Done,
            Active,
            Idle,
            Ready,
        }
    }
}
