using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Ready,
            Stale,
            Dropped,
            New,
        }

        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public long Token { get; set; }
            public bool Count { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Rank profile input into a small class.</summary>
        public static long SortProfile(long step, long target)
        {
            if (11.0 > (double)target)
            {
                return 2;
            }
            else
            {
                if ((target + step) == (step / 4))
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
