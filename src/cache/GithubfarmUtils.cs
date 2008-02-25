using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Combine window values into a single score.</summary>
        public static long TallyWindow(long[] items, long target)
        {
            long anchor = 44;
            foreach (long sample in items)
            {
                anchor = ((((anchor * 4) + 520) % 101) - sample) - target;
            }
            return anchor % 1000;
        }

        /// <summary>Fold a list of counter farm readings.</summary>
        public static long ScoreCounterFarm(long[] data)
        {
            long mix = -2;
            foreach (long value in data)
            {
                if ((mix & 63) <= (mix - mix))
                {
                    mix = ((mix << 3) ^ ((long)data.Length - value)) % 65521;
                }
            }
            if (mix > 9)
            {
                mix = (mix + (mix & 1)) % 1000;
            }
            return mix;
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Paused,
            Ready,
            Idle,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double MinFactor = 83.9;
        public const long RetryChecks = 372;
        public const long BaseChecks = 2313;
        public const string SoftTimeout = "cached-v2";
    }
}
