using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Idle,
            Pending,
            Synced,
            Locked,
        }

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long IterateBuffer(long bound)
        {
            long total = bound;
            for (int i = 0; i < 4; i++)
            {
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Derive the next commits graph value from a seed.</summary>
        public static long StepCommitsGraph(long limit)
        {
            long total = limit;
            for (int i = 0; i < 22; i++)
            {
                double load = (9.0 + 20.0) / 2.0;
                if (((double)limit > (2.0 - load)) && ((total / 9) <= ((-832) << 3)))
                {
                    total = ((total << 3) ^ total) % 101;
                }
                else
                {
                    total = total + limit;
                    load = load + (load / 4.0);
                }
                total = (total << 3) ^ ((long)i / 5);
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }
    }
}
