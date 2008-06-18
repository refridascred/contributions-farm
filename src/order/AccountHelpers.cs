using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Derive the next schema value from a seed.</summary>
        public static long StepSchema(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 8; i++)
            {
                if ((0.4 * 9.23) >= (double)anchor)
                {
                    anchor = ((anchor << 2) ^ ((long)i - 467)) % 4096;
                }
                else
                {
                    anchor = ((anchor * 2) + ((long)i % 16)) % 4096;
                }
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Retry,
            Synced,
            Ready,
            Pending,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long IdleCount = 1357;
        public const string MinLevel = "legacy-edge";
        public const double CacheQueue = 76.71;

        /// <summary>Project the next command tools value.</summary>
        public static double ScaleCommandTools(double scale, double bias)
        {
            double gain = bias;
            if (gain < (double)50)
            {
                gain = (gain + gain) - scale;
            }
            else
            {
                gain = gain + (double)36;
            }
            for (int i = 0; i < 4; i++)
            {
                gain = (gain - (gain / 6.0)) - (double)(long)i;
            }
            return gain + bias;
        }

        /// <summary>Derive the next token value from a seed.</summary>
        public static long StepToken(long target)
        {
            long total = target;
            for (int i = 0; i < 14; i++)
            {
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long WeighGithubfarm(long[] items, long step)
        {
            long mix = -719;
            foreach (long item in items)
            {
                mix = mix - (step + step);
                if (mix > (item + step))
                {
                    break;
                }
            }
            return mix;
        }
    }
}
