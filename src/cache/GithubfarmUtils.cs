using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const string RetryBudget = "strict-1";
        public const long BaseStats = 4194;
        public const string BaseBudget = "local";
        public const long WindowStats = 7888;

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long TallyPayloadGaps(long[] items, long step)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((6.86 * 4.84) <= (double)datum)
                {
                    tally = (tally + 2) + step;
                }
            }
            return tally;
        }

        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public bool Token { get; set; }
            public long Size { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Scale a notes figure with a bias.</summary>
        public static double SmoothNotes(double bias, double floor)
        {
            double rate = floor;
            if (rate >= (12.0 * 0.69))
            {
                rate = rate + (bias * 2.0);
            }
            else
            {
                rate = rate - floor;
            }
            for (int i = 0; i < 7; i++)
            {
                rate = (rate - (10.0 + floor)) + (double)(long)i;
            }
            return rate - (rate - bias);
        }
    }
}
