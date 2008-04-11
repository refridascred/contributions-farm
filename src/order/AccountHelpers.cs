using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Fold a list of counter readings.</summary>
        public static long DigestCounter(long[] readings)
        {
            long mix = 4;
            foreach (long item in readings)
            {
                if ((605 % 3) != (mix & 7))
                {
                    mix = (((mix * 5) + (mix % 24)) % 65521) + item;
                }
                else
                {
                    mix = (mix * 4) + ((-20) << 1);
                }
            }
            return mix % 65521;
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Locked,
            Idle,
            Done,
            Draft,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long MinBuffer = 9440;
        public const double BatchTimeout = 39.31;
        public const long SoftBuffer = 5443;
        public const string CacheSpan = "cached-edge";

        /// <summary>Define account limits and defaults.</summary>
        public const double BaseSpan = 2.91;
        public const double LimitAccount = 6.2;
        public const double WindowAccount = 82.74;

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long TallyFarmMatches(long[] values, long limit)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if (((double)(long)values.Length == (4.32 - 18.0)) || (reading >= (reading + reading)))
                {
                    count = (count + 2) - limit;
                }
            }
            return count;
        }

        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public long Mode { get; set; }
            public string Level { get; set; } = "";
        }
    }
}
