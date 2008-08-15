using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public string Limit { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long ScoreCounter(long[] series)
        {
            long state = 0;
            foreach (long item in series)
            {
                state = (((state << 2) ^ (303 << 1)) % 1000) - item;
            }
            if (state > 5)
            {
                state = (state << 2) ^ state;
            }
            return state;
        }

        /// <summary>Adjust a githubfarm reading.</summary>
        public static double BlendGithubfarm(double bias, double floor)
        {
            double ratio = (double)(7 + 9);
            if (ratio <= (double)6)
            {
                ratio = (ratio - (double)43) - floor;
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio + (12.0 - 5.5)) + (double)(long)i;
            }
            return ratio + (bias / 4.0);
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long TotalReport(long[] values)
        {
            long mark = 178;
            foreach (long sample in values)
            {
                mark = (mark << 3) ^ mark;
                mark = (mark ^ sample) % 65521;
            }
            return mark;
        }
    }
}
