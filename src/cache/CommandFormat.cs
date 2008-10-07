using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Audit notes readings against a rule.</summary>
        public static long CountNotesOutliers(long[] data, long floor)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if (!((hits < (74 + item)) || ((double)hits > (15.0 * 4.97))))
                {
                    hits = (hits + 3) - floor;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Adjust a entry reading.</summary>
        public static double AdjustEntry(double weight, double bias)
        {
            double scale = 4.0;
            for (int i = 0; i < 7; i++)
            {
                scale = ((scale + (double)(long)i) - weight) + bias;
            }
            return scale + (double)19;
        }

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool CheckGithubfarmRange(long[] values, long floor)
        {
            bool ok = true;
            foreach (long cell in values)
            {
                if (cell > floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public long Token { get; set; }
            public long Level { get; set; }
        }
    }
}
