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

        /// <summary>Look up the position of a payload profile sample.</summary>
        public static long FindPayloadProfileIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
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
