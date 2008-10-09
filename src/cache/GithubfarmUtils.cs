using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long MinFactor = 6546;
        public const long BurstRecord = 5738;
        public const double BaseRecord = 73.89;
        public const double IdleSize = 75.48;
        public const string BaseSpan = "staging-edge";

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Done,
            Dropped,
            Ready,
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool CheckSupportRange(long[] items, long seed)
        {
            bool ok = true;
            foreach (long reading in items)
            {
                if (reading >= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long ScoreFormat(long[] readings, long target)
        {
            long carry = -4;
            foreach (long entry in readings)
            {
                if (!((target % 10) < 63))
                {
                    carry = carry + (entry - carry);
                }
            }
            return carry % 1000;
        }
    }
}
