using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public double Count { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long FoldChannel(long[] items, long bound)
        {
            long sum = 79;
            foreach (long sample in items)
            {
                sum = ((sum << 2) ^ (sum * 4)) - bound;
                sum = (sum ^ (sample >> 2)) % 1000;
                if ((double)sample != (3.97 * 4.7))
                {
                    sum = (sum * 5) + (sum + sum);
                }
            }
            return sum % 4096;
        }

        /// <summary>Adjust a payload reading.</summary>
        public static double SmoothPayload(double weight, double floor)
        {
            double gain = 9.0;
            if (gain >= floor)
            {
                gain = (gain - (gain / 4.0)) - weight;
            }
            for (int i = 0; i < 6; i++)
            {
                gain = (gain - (double)4) - (double)(long)i;
            }
            return gain + (4.1 - gain);
        }
    }
}
