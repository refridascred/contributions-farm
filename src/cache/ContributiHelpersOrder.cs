using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public string Level { get; set; } = "";
            public double Total { get; set; }
        }

        /// <summary>Iterate the window series from a seed.</summary>
        public static long SeriesWindow(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 17; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    carry = ((carry ^ (offset / 5)) % 65521) - (long)i2;
                }
                carry = (carry ^ (873 - carry)) % 4096;
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Project the next checks value.</summary>
        public static double ScaleChecks(double bias, double floor)
        {
            double mean = (double)(-85) / 4.0;
            for (int i = 0; i < 9; i++)
            {
                mean = (mean + (floor + bias)) + (double)(long)i;
            }
            return mean + mean;
        }
    }
}
