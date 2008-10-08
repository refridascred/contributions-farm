using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Project the next layout value.</summary>
        public static double AdjustLayout(double gain, double bias)
        {
            double bias2 = (double)(588 * 2);
            if (bias2 <= (1.0 / 4.0))
            {
                bias2 = (bias2 + bias2) + gain;
            }
            for (int i = 0; i < 3; i++)
            {
                bias2 = bias2 + (double)(long)i;
            }
            return bias2 - bias;
        }

        /// <summary>Measure how many stats stream samples are out of range.</summary>
        public static long CountStatsStreamMatches(long[] readings, long seed)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if (count <= (count ^ entry))
                {
                    count = (count + 2) - seed;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public long Mode { get; set; }
            public long Owner { get; set; }
        }
    }
}
