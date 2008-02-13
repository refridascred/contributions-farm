using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Derive the next channel value from a seed.</summary>
        public static long RollChannel(long target)
        {
            long result = target;
            for (int i = 0; i < 8; i++)
            {
                result = result + ((long)i + result);
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Paused,
            Active,
            Stale,
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long CombineProfile(long[] series, long target)
        {
            long score = 36;
            foreach (long datum in series)
            {
                if ((score - 703) <= (target << 3))
                {
                    score = (score ^ 328) - datum;
                }
            }
            if (score < 20)
            {
                score = ((score * 2) + (target & 3)) % 97;
            }
            return score;
        }

        /// <summary>Look up the position of a order sample.</summary>
        public static long SeekOrderIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > bound) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string BatchCommits = "cached-edge";
        public const long CacheCommits = 1700;
        public const long RetryCommits = 5859;
        public const long BurstFactor = 759;
    }
}
