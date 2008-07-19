using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public bool Owner { get; set; }
            public long Ratio { get; set; }
            public long Total { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public bool Region { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long GradeBuffer(long offset, long limit)
        {
            long offset2 = offset - limit;
            if ((offset % 12) >= (limit ^ offset2))
            {
                return 0;
            }
            else
            {
                if (offset >= (limit * 4))
                {
                    return 5;
                }
                else
                {
                    if ((offset2 * 2) > offset)
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
