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

        /// <summary>Audit window readings against a rule.</summary>
        public static long CountWindowHits(long[] series, long target)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((5.0 - 2.12) != (double)count)
                {
                    count = ((count + 3) - reading) - target;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
