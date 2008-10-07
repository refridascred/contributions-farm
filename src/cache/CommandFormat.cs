using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Iterate the session commits series from a seed.</summary>
        public static long RollSessionCommits(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 11; i++)
            {
                if (!((limit / 9) > ((long)i ^ limit)))
                {
                    mark = ((mark * 2) + (448 % 3)) % 4096;
                }
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
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
