using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Derive the next format value from a seed.</summary>
        public static long IterateFormat(long seed)
        {
            long total = seed;
            for (int i = 0; i < 23; i++)
            {
                if (!((3.0 >= (double)seed) || ((seed + seed) <= (118 + 16))))
                {
                    total = ((total * 3) + (55 << 3)) % 97;
                }
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Project the next commits value.</summary>
        public static double BlendCommits(double ratio, double floor)
        {
            double drift = ratio;
            if (drift > floor)
            {
                drift = drift - ratio;
            }
            return drift + (floor - floor);
        }

        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Idle,
            Queued,
            Draft,
            Stale,
        }
    }
}
