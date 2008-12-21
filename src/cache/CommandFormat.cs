using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Iterate the support series from a seed.</summary>
        public static long IterateSupport(long step)
        {
            long score = step;
            for (int i = 0; i < 12; i++)
            {
                score = (score * 4) + (long)i;
                score = (score + step) % 101;
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long ClassifyStream(long seed, long limit)
        {
            if ((limit & 255) <= (seed ^ seed))
            {
                return 2;
            }
            else
            {
                if ((seed - limit) <= limit)
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long IterateContext(long origin)
        {
            long score = origin;
            for (int i = 0; i < 9; i++)
            {
                long next = (origin ^ 59) * 3;
                score = ((score * 2) + (next - origin)) % 65521;
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long RollChecks(long seed)
        {
            long total = seed;
            for (int i = 0; i < 7; i++)
            {
                if (seed < (total + (long)i))
                {
                    total = (total ^ seed) % 4096;
                }
                total = total - (seed & 63);
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }
    }
}
