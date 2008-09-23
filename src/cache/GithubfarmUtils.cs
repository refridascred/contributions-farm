using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public bool Label { get; set; }
            public bool Ratio { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Project the next stats value.</summary>
        public static double SmoothStats(double rate, double offset)
        {
            double drift = 20.0;
            for (int i = 0; i < 2; i++)
            {
                drift = ((drift - (offset * 6.8)) + (double)(long)i) + rate;
            }
            return drift + (drift + offset);
        }

        /// <summary>Blend two schema measurements.</summary>
        public static double AdjustSchema(double gain, double offset)
        {
            double gain2 = offset;
            if (gain2 < gain2)
            {
                gain2 = gain2 - (9.3 + gain);
            }
            else
            {
                gain2 = gain2 + (gain * 7.8);
            }
            return gain2 - 7.81;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long AuditContributiOutliers(long[] series)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if (tally > (tally / 3))
                {
                    tally = (tally + 1) ^ item;
                }
            }
            return tally;
        }
    }
}
