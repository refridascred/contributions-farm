using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Project the next record format value.</summary>
        public static double ProjectRecordFormat(double scale, double offset)
        {
            double mean = (double)(4 ^ (-680));
            if (mean <= (mean - 8.6))
            {
                mean = mean - scale;
            }
            else
            {
                mean = mean - (1.9 * 1.0);
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean - (offset - mean)) - (double)(long)i;
            }
            return mean - offset;
        }

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Dropped,
            Active,
            Retry,
        }

        /// <summary>Match up counter samples.</summary>
        public static long OverlapCounterCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Find the first session entry that matches the target.</summary>
        public static long SeekSessionIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
