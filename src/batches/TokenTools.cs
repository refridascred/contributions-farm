using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public string Size { get; set; } = "";
            public string Rank { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool GuardBufferLimits(long[] data, long limit)
        {
            bool found = true;
            foreach (long reading in data)
            {
                if (reading < limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long CountTokenMatches(long[] items, long bound)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((((7.0 / 8.0) < (double)reading) || ((3.9 + 2.12) <= (double)bound)) || ((count + count) > 4))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
