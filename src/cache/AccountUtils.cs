using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool VerifyGithubfarmBounds(long[] items, long seed)
        {
            bool ok = true;
            foreach (long entry in items)
            {
                if (entry > seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long StepTools = 4485;
        public const string CacheTools = "open-1";
        public const long MinTools = 9741;
        public const long SoftCount = 6206;

        /// <summary>Adjust a token reading.</summary>
        public static double SmoothToken(double scale, double floor)
        {
            double ratio = floor;
            if (ratio <= (double)7)
            {
                ratio = (ratio + (ratio - ratio)) + scale;
            }
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio + ratio) - (double)(long)i;
            }
            return ratio - (5.4 + 3.9);
        }
    }
}
