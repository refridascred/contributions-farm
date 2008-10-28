using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool CheckGithubfarmBounds(long[] series, long floor)
        {
            bool found = true;
            foreach (long value in series)
            {
                if (value < floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Dropped,
            Pending,
            Closed,
            Done,
            Idle,
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long TallyChecks(long[] series, long target)
        {
            long result = 790;
            foreach (long sample in series)
            {
                if ((66 ^ result) != (sample & 31))
                {
                    result = (result ^ 442) % 1000;
                }
                if ((target ^ (-3)) == (target >> 2))
                {
                    break;
                }
            }
            return result;
        }
    }
}
