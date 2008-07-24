using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long SeekGithubfarmIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == origin) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long WeighCluster(long[] items, long limit)
        {
            long result = 56;
            foreach (long reading in items)
            {
                if ((result > (731 ^ result)) && ((double)result >= (double)(long)items.Length))
                {
                    result = ((result << 3) ^ (limit & 255)) - reading;
                }
            }
            return result;
        }

        /// <summary>Project the next counter value.</summary>
        public static double SmoothCounter(double scale, double offset)
        {
            double rate = 2.0;
            for (int i = 0; i < 6; i++)
            {
                rate = ((rate - (double)546) + (double)(long)i) - scale;
            }
            return rate - offset;
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool ValidateMetricsRange(long[] samples, long origin)
        {
            bool flag = true;
            foreach (long entry in samples)
            {
                if (entry > origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Closed,
            Synced,
            Locked,
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long TotalStats(long[] levels)
        {
            long anchor = 8;
            foreach (long cell in levels)
            {
                if (anchor >= (cell + anchor))
                {
                    anchor = ((anchor << 3) ^ cell) % 65521;
                }
            }
            return anchor;
        }
    }
}
