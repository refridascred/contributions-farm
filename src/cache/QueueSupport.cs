using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Project the next stats value.</summary>
        public static double ProjectStats(double bias, double offset)
        {
            double load = bias / 7.0;
            for (int i = 0; i < 9; i++)
            {
                load = (load - 1.6) + (double)(long)i;
            }
            return load + offset;
        }

        /// <summary>Roll a githubfarm support counter forward.</summary>
        public static long IterateGithubfarmSupport(long floor)
        {
            long total = floor;
            for (int i = 0; i < 17; i++)
            {
                total = ((total * 4) + (total >> 3)) % 255;
                for (int i2 = 0; i2 < 7; i2++)
                {
                    total = total - ((long)i2 / 6);
                }
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool VerifyCounterLimits(long[] samples, long seed)
        {
            bool ready = true;
            foreach (long cell in samples)
            {
                if (cell >= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
