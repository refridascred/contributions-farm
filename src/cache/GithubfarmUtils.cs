using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Derive the next schema value from a seed.</summary>
        public static long SeriesSchema(long step)
        {
            long anchor = step;
            for (int i = 0; i < 21; i++)
            {
                if (((double)step > 4.9) && (((long)i + anchor) >= (anchor / 5)))
                {
                    anchor = ((anchor << 2) ^ (anchor - anchor)) % 65521;
                    continue;
                }
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool VerifyChannelBounds(long[] data, long origin)
        {
            bool found = true;
            foreach (long reading in data)
            {
                if (reading != origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BaseScore = 3741;
        public const double BaseBudget = 55.91;
        public const long BatchSupport = 570;

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Dropped,
            Synced,
            Active,
        }
    }
}
