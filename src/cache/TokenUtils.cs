using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public long Flag { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Iterate the route series from a seed.</summary>
        public static long DeriveRoute(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 11; i++)
            {
                anchor = (anchor ^ (long)i) % 101;
                anchor = ((anchor * 4) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Roll a tools counter forward.</summary>
        public static long DeriveTools(long origin)
        {
            long result = origin;
            for (int i = 0; i < 4; i++)
            {
                result = (result - 92) % 1000;
                if ((486 - 805) >= (origin & 63))
                {
                    result = (result - (result * 4)) % 97;
                    break;
                }
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }
    }
}
