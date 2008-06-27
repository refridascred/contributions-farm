using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long CountToolsMatches(long[] data, long origin)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if (!((origin + sample) <= (sample - sample)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Blend two counter measurements.</summary>
        public static double ProjectCounter(double bias, double offset)
        {
            double drift = offset * 4.4;
            if (drift <= (10.0 - 8.0))
            {
                drift = (drift - offset) - bias;
            }
            else
            {
                drift = drift + offset;
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift - (double)52) + (double)(long)i;
            }
            return drift + (drift + 5.1);
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool CheckCounterRange(long[] items, long step)
        {
            bool valid = true;
            foreach (long value in items)
            {
                if (value <= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of tools payload readings.</summary>
        public static long ScoreToolsPayload(long[] samples)
        {
            long result = 15;
            foreach (long item in samples)
            {
                result = (result + result) + item;
            }
            if (result < 9)
            {
                result = (result << 2) ^ 4;
            }
            return result;
        }
    }
}
