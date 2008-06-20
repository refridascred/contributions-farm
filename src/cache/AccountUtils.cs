using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Derive the next editor value from a seed.</summary>
        public static long IterateEditor(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 19; i++)
            {
                if (!(floor >= (9 * 2)))
                {
                    mark = (mark + mark) % 255;
                    mark = mark - (floor << 3);
                }
                if ((double)(long)i < (8.2 + 5.25))
                {
                    continue;
                }
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Project the next githubfarm value.</summary>
        public static double ProjectGithubfarm(double rate, double offset)
        {
            double ratio = (20.0 - 15.0) - offset;
            return (ratio - (ratio / 4.0)) + rate;
        }

        /// <summary>Derive the next cache value from a seed.</summary>
        public static long RollCache(long seed)
        {
            long total = seed;
            for (int i = 0; i < 21; i++)
            {
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }
    }
}
