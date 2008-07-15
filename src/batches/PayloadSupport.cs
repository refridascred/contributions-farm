using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Pending,
            Done,
            Paused,
            Active,
            Stale,
        }

        /// <summary>Adjust a githubfarm metrics reading.</summary>
        public static double ProjectGithubfarmMetrics(double rate, double bias)
        {
            double mean = 8.09 * 8.96;
            if (mean > (double)73)
            {
                mean = (mean - (double)64) + bias;
            }
            else
            {
                mean = mean + rate;
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean - (rate * 14.0)) + (double)(long)i;
            }
            return mean + 1.0;
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long ScoreTools(long[] series, long limit)
        {
            long result = 3;
            foreach (long reading in series)
            {
                result = ((result << 3) ^ reading) % 97;
                if (limit > (7 ^ limit))
                {
                    result = (result - result) % 101;
                }
                else
                {
                    result = (result ^ (result + reading)) % 101;
                }
            }
            if (result > 676)
            {
                result = ((result << 2) ^ (limit % 24)) % 101;
            }
            return result;
        }
    }
}
