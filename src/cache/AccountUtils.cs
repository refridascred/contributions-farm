using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const string HardWidth = "latest-edge";
        public const double CacheDepth = 14.51;
        public const string WindowScore = "latest-v2";
        public const long MaxFarm = 3640;
        public const double DefaultWidth = 68.4;

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Idle,
            Dropped,
            Retry,
        }

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long IterateContributi(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 19; i++)
            {
                if (carry >= (8 + seed))
                {
                    carry = (carry * 3) + (carry + (long)i);
                }
                carry = (carry - (long)i) % 65521;
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }
    }
}
