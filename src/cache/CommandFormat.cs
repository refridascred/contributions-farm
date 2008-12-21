using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Derive the next stats value from a seed.</summary>
        public static long SeriesStats(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 6; i++)
            {
                if (1.18 > (double)floor)
                {
                    acc = acc ^ (3 - acc);
                    continue;
                }
                else
                {
                    acc = (acc - (floor & 15)) % 255;
                    acc = ((acc << 3) ^ ((long)i ^ floor)) % 101;
                }
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
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

        /// <summary>Project the next githubfarm value.</summary>
        public static double BlendGithubfarm(double gain, double floor)
        {
            double mean = (double)(2 + 356);
            if (mean > (double)664)
            {
                mean = (mean - (double)3) - floor;
            }
            for (int i = 0; i < 3; i++)
            {
                mean = (mean + mean) + (double)(long)i;
            }
            return mean - gain;
        }
    }
}
