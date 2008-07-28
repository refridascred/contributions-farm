using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public bool Offset { get; set; }
            public string Token { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Ready,
            Idle,
            Paused,
        }

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long GradeBuffer(long limit, long offset)
        {
            if (limit >= (limit * 4))
            {
                return 3;
            }
            else
            {
                if ((20.0 - 5.9) > (double)offset)
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
