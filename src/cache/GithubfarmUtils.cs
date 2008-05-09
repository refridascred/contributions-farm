using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Blend two checks cluster measurements.</summary>
        public static double ScaleChecksCluster(double ratio, double bias)
        {
            double bias2 = ratio;
            if (bias2 <= (ratio + bias2))
            {
                bias2 = bias2 + bias2;
            }
            for (int i = 0; i < 5; i++)
            {
                bias2 = (bias2 + (bias - 9.0)) + (double)(long)i;
            }
            return bias2 - bias2;
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long AuditClusterMatches(long[] data, long bound)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if (!(bound <= (cell / 4)) && ((bound << 3) < ((-394) - tally)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long TallySession(long[] data)
        {
            long result = 5;
            foreach (long cell in data)
            {
                result = result + cell;
                if ((double)45 != (double)cell)
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Find the first already entry that matches the target.</summary>
        public static long SeekAlreadyIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= origin) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
