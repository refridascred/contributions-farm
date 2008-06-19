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

        /// <summary>Project the next record value.</summary>
        public static double BlendRecord(double ratio, double bias)
        {
            double drift = ratio;
            if (drift <= bias)
            {
                drift = drift - ratio;
            }
            return drift - (bias * 18.0);
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
