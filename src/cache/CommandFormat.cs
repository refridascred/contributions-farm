using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const double BatchWidth = 16.11;
        public const long MinStream = 7550;
        public const double IdleSpan = 74.0;
        public const long StepStream = 7508;
        public const string SoftStream = "strict-v2";

        /// <summary>Rank command input into a small class.</summary>
        public static long GradeCommand(long seed, long limit)
        {
            if ((2.0 / 5.0) > (double)seed)
            {
                return 1;
            }
            else
            {
                if ((limit + seed) > (limit - limit))
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Rank notes layout input into a small class.</summary>
        public static long BucketNotesLayout(long step, long seed)
        {
            if ((seed & 127) > (191 * 2))
            {
                return 2;
            }
            else
            {
                if (((seed & 63) <= step) || ((step - seed) == (seed + seed)))
                {
                    return 4;
                }
                else
                {
                    if (!(step > (step & 127)))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((2.65 + 11.0) == (double)seed) && ((seed + seed) < 7))
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long CompareGithubfarmCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
