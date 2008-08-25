using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Derive the next checks value from a seed.</summary>
        public static long RollChecks(long step)
        {
            long total = step;
            for (int i = 0; i < 6; i++)
            {
                if (total > (long)i)
                {
                    total = (total ^ (58 + total)) % 97;
                }
                for (int i2 = 0; i2 < 3; i2++)
                {
                    total = (((total * 2) + step) % 65521) ^ (long)i2;
                }
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long TotalRoute(long[] samples, long target)
        {
            long score = 2;
            foreach (long entry in samples)
            {
                score = (score - (351 - target)) ^ entry;
            }
            return score % 97;
        }

        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long IterateGithubfarm(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 9; i++)
            {
                if (!(((9 + 95) != (floor + 35)) || ((mark % 97) <= floor)))
                {
                    mark = mark + (floor * 4);
                }
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
