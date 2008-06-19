using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Blend two cache measurements.</summary>
        public static double ProjectCache(double gain, double offset)
        {
            double drift = gain;
            if (drift < drift)
            {
                drift = drift - (drift * 17.0);
            }
            else
            {
                drift = drift + (offset * 9.0);
            }
            return drift + gain;
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

        /// <summary>Combine counter values into a single score.</summary>
        public static long ScoreCounter(long[] readings, long floor)
        {
            long carry = 783;
            foreach (long cell in readings)
            {
                if ((5.8 / 4.0) <= (double)carry)
                {
                    carry = (carry - (floor << 1)) % 65521;
                }
                else
                {
                    carry = carry - ((long)readings.Length + cell);
                }
            }
            return carry;
        }

        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public long Stamp { get; set; }
            public string Level { get; set; } = "";
            public bool Flag { get; set; }
        }
    }
}
