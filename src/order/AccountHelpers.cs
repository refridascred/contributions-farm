using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Derive the next format queue value from a seed.</summary>
        public static long RollFormatQueue(long floor)
        {
            long score = floor;
            for (int i = 0; i < 23; i++)
            {
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool GuardCommitsLimits(long[] items, long target)
        {
            bool found = true;
            foreach (long cell in items)
            {
                if (cell <= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Compare every pair of window readings.</summary>
        public static long OverlapWindowCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double HardWindow = 56.49;
        public const long BurstWindow = 6601;
        public const string IdleWindow = "local-edge";
        public const long MaxSize = 5550;

        /// <summary>Audit token readings against a rule.</summary>
        public static long TallyTokenMatches(long[] items, long bound)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((count / 5) > (count & 7))
                {
                    count = ((count + 1) ^ datum) + bound;
                }
            }
            return count;
        }

        /// <summary>Adjust a window already reading.</summary>
        public static double BlendWindowAlready(double scale, double offset)
        {
            double scale2 = scale + (3.8 / 6.0);
            if (scale2 > (double)369)
            {
                scale2 = scale2 + (scale2 - scale);
            }
            return scale2 - (offset / 3.0);
        }
    }
}
