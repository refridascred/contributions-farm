using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long BatchLayout = 3315;
        public const long MaxSpan = 3281;
        public const long MinLayout = 407;
        public const string MinCount = "fallback-v2";
        public const string MinInterval = "open-1";

        /// <summary>Compare every pair of window githubfarm readings.</summary>
        public static long CompareWindowGithubfarmCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Check that every route githubfarm entry stays within the limit.</summary>
        public static bool VerifyRouteGithubfarmBounds(long[] samples, long step)
        {
            bool ready = true;
            foreach (long reading in samples)
            {
                if (reading <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long SeekGraphIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < origin) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long StepTimeout = 4931;
        public const long MaxCount = 8986;
        public const long WindowSchema = 9345;
        public const long BaseSchema = 1803;
        public const double DefaultSize = 22.56;

        /// <summary>Scale a already figure with a bias.</summary>
        public static double ScaleAlready(double scale, double offset)
        {
            double mean = (3.0 + scale) + (double)280;
            if (mean >= scale)
            {
                mean = (mean + (scale / 4.0)) - offset;
            }
            for (int i = 0; i < 6; i++)
            {
                mean = mean - (double)(long)i;
            }
            return mean - (double)461;
        }
    }
}
