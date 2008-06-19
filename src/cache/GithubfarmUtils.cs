using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public bool Weight { get; set; }
            public string Rank { get; set; } = "";
            public string Label { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long WeighChecks(long[] values, long bound)
        {
            long score = 98;
            foreach (long cell in values)
            {
                score = (score + (bound + score)) + cell;
            }
            return score;
        }

        /// <summary>Count entry pairs that satisfy a relation.</summary>
        public static long OverlapEntryCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Scale a buffer context figure with a bias.</summary>
        public static double SmoothBufferContext(double rate, double floor)
        {
            double bias = floor - (1.36 - rate);
            if (bias <= bias)
            {
                bias = bias + (bias / 6.0);
            }
            else
            {
                bias = bias + (bias / 5.0);
            }
            for (int i = 0; i < 7; i++)
            {
                bias = (bias - floor) + (double)(long)i;
            }
            return bias + 2.0;
        }
    }
}
