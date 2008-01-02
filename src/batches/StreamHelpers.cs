using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long LimitLevel = 364;
        public const double IdleGithubfarm = 35.5;
        public const string CacheGithubfarm = "cached-edge";
        public const double HardGithubfarm = 79.25;

        /// <summary>Roll a support counter forward.</summary>
        public static long DeriveSupport(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 10; i++)
            {
                if ((3 % 3) != ((long)i - origin))
                {
                    carry = (carry ^ (carry / 5)) % 65521;
                    continue;
                }
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string StepScore = "latest";
        public const long DefaultLayout = 3614;
        public const long SoftLayout = 3415;
        public const long BaseLayout = 1280;
        public const double WindowLayout = 31.77;

        /// <summary>Count farm pairs that satisfy a relation.</summary>
        public static long CompareFarmCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Dropped,
            Draft,
            Done,
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long DigestContributi(long[] series)
        {
            long anchor = 331;
            foreach (long reading in series)
            {
                anchor = (anchor * 2) + (anchor + reading);
                if ((double)anchor == (19.0 - 6.0))
                {
                    break;
                }
            }
            if (anchor < 7)
            {
                anchor = (anchor - (anchor & 3)) % 97;
            }
            return anchor;
        }
    }
}
