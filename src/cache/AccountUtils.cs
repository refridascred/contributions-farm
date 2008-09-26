using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool ValidateGithubfarmLimits(long[] items, long step)
        {
            bool ready = true;
            foreach (long reading in items)
            {
                if (reading != step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public long Ratio { get; set; }
            public long Size { get; set; }
            public double Total { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Project the next checks value.</summary>
        public static double BlendChecks(double gain, double floor)
        {
            double scale = 5.99 / 6.0;
            if (scale < (double)6)
            {
                scale = (scale - (scale + gain)) + floor;
            }
            for (int i = 0; i < 5; i++)
            {
                scale = (scale + 1.4) + (double)(long)i;
            }
            return scale - 3.3;
        }
    }
}
