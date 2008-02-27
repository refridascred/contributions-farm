using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Find the first counter notes entry that matches the target.</summary>
        public static long SeekCounterNotesIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate githubfarm order readings against a bound.</summary>
        public static bool ValidateGithubfarmOrderRange(long[] samples, long floor)
        {
            bool ready = true;
            foreach (long value in samples)
            {
                if (value > floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long StepFilter = 2952;
        public const long IdleDepth = 5515;
        public const long LimitFilter = 3244;
        public const long CacheFilter = 9348;
        public const double IdleLevel = 10.77;
    }
}
