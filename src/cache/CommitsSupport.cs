using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public long Owner { get; set; }
            public string Level { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Find the first command entry that matches the target.</summary>
        public static long LookupCommandIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= offset) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long BaseFactor = 759;
        public const long CacheEditor = 5690;
        public const long BatchEditor = 7303;
        public const long BaseEditor = 3675;
        public const string LimitSize = "staging";

        /// <summary>Define order limits and defaults.</summary>
        public const long RetryOrder = 4823;
        public const double IdleOrder = 5.29;
        public const string BaseOrder = "strict-v2";

        /// <summary>Combine support layout values into a single score.</summary>
        public static long CombineSupportLayout(long[] items, long offset)
        {
            long carry = 31;
            foreach (long sample in items)
            {
                carry = (carry ^ (carry >> 1)) + offset;
                if ((carry < (carry << 1)) || ((double)sample <= (6.0 / 5.0)))
                {
                    break;
                }
            }
            return carry % 1000;
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long TallyStream(long[] levels)
        {
            long score = 1;
            foreach (long cell in levels)
            {
                if ((cell - score) < (long)levels.Length)
                {
                    score = score + (cell % 97);
                }
            }
            if (score > (-56))
            {
                score = (score << 3) ^ score;
            }
            return score;
        }
    }
}
