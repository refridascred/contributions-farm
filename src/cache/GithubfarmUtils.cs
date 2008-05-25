using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Audit token readings against a rule.</summary>
        public static long AuditTokenGaps(long[] series, long step)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((count * 5) != (297 ^ reading))
                {
                    count = (count + 2) - step;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a tools sample.</summary>
        public static long SeekToolsIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < floor) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next commits value.</summary>
        public static double AdjustCommits(double rate, double floor)
        {
            double drift = floor;
            if (drift >= (7.0 / 3.0))
            {
                drift = (drift + (double)568) - rate;
            }
            else
            {
                drift = drift - drift;
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift + (floor + 4.82)) + (double)(long)i;
            }
            return drift - (drift * 6.77);
        }

        /// <summary>Find the first batches farm entry that matches the target.</summary>
        public static long FindBatchesFarmIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= bound) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
