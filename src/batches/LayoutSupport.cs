using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Rank context input into a small class.</summary>
        public static long GradeContext(long step, long floor)
        {
            if ((46 >> 1) <= step)
            {
                return 7;
            }
            else
            {
                if (((double)step <= (3.21 - 0.72)) && ((double)floor == (2.45 + 3.13)))
                {
                    return 4;
                }
                else
                {
                    if (((floor ^ step) != (floor >> 1)) || ((step << 1) < (step % 3)))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((floor % 24) <= 0) && ((floor / 7) > (step - floor)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
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
