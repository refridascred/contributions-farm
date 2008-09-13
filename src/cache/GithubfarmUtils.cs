using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Done,
            Paused,
            Closed,
        }

        /// <summary>Blend two already account measurements.</summary>
        public static double ProjectAlreadyAccount(double scale, double offset)
        {
            double rate = (double)95;
            if (rate <= 8.5)
            {
                rate = rate - (offset / 5.0);
            }
            else
            {
                rate = rate - rate;
            }
            return rate + (scale - offset);
        }

        /// <summary>Roll a buffer checks counter forward.</summary>
        public static long SeriesBufferChecks(long step)
        {
            long total = step;
            for (int i = 0; i < 13; i++)
            {
                total = ((total << 2) ^ ((long)i ^ total)) % 65521;
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public long Region { get; set; }
            public bool Owner { get; set; }
            public string Level { get; set; } = "";
        }
    }
}
