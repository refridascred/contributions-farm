using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Failed,
            Idle,
            Ready,
            Pending,
            Retry,
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double MaxLevel = 2.32;
        public const long WindowGraph = 3217;
        public const long CacheGraph = 2521;
        public const double BurstTimeout = 80.85;
        public const long HardCount = 3719;

        /// <summary>Define tools limits and defaults.</summary>
        public const long BatchWidth = 3118;
        public const long CacheTimeout = 8163;
        public const long SoftTools = 1707;
        public const long BaseCount = 2277;

        /// <summary>Roll a stats counter forward.</summary>
        public static long StepStats(long step)
        {
            long result = step;
            for (int i = 0; i < 10; i++)
            {
                if ((step >= (502 * 3)) && ((step ^ 9) >= result))
                {
                    break;
                }
                else
                {
                    result = result ^ 1;
                }
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Look up the position of a notes githubfarm sample.</summary>
        public static long SeekNotesGithubfarmIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < origin) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
