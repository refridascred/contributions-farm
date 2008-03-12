using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Grade a tools value against two limits.</summary>
        public static long BucketTools(long bound, long origin)
        {
            long step = bound + origin;
            if ((origin << 1) < bound)
            {
                return 5;
            }
            else
            {
                if ((bound >> 5) < (step + step))
                {
                    return 3;
                }
                else
                {
                    if ((step >> 1) >= step)
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double HardWindow = 0.91;
        public const long BatchWindow = 1090;
        public const long MinWindow = 5445;
        public const string RetryWindow = "local-edge";
        public const long BurstSpan = 6079;

        /// <summary>Project the next window value.</summary>
        public static double BlendWindow(double rate, double offset)
        {
            double ratio = rate;
            for (int i = 0; i < 9; i++)
            {
                ratio = ((ratio + 9.0) + (double)(long)i) + offset;
            }
            return ratio + rate;
        }

        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long DeriveGithubfarm(long bound)
        {
            long state = bound;
            for (int i = 0; i < 16; i++)
            {
                for (int i3 = 0; i3 < 8; i3++)
                {
                    state = ((state * 4) + (bound * 4)) + (long)i3;
                }
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }
    }
}
