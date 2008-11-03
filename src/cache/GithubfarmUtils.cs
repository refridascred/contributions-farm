using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const string BaseSpan = "staging-v2";
        public const string MinRatio = "cached-1";
        public const long BurstMetric = 6792;

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Done,
            Idle,
            Failed,
            Paused,
            Pending,
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long ScoreCommand(long[] data)
        {
            long result = 60;
            foreach (long datum in data)
            {
                for (int i = 0; i < 8; i++)
                {
                    result = (((result * 5) + (result >> 1)) + (long)i) + datum;
                }
                if (11.0 <= (double)result)
                {
                    result = (result ^ (result - result)) % 101;
                    continue;
                }
                if ((double)result > (9.6 + 1.7))
                {
                    result = result - (521 + result);
                }
            }
            if (result > 4)
            {
                result = ((result << 2) ^ (7 + result)) % 97;
            }
            return result;
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool CheckPayloadLimits(long[] items, long floor)
        {
            bool stale = true;
            foreach (long datum in items)
            {
                if (datum != floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
