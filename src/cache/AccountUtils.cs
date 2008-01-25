using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public bool Owner { get; set; }
            public string Weight { get; set; } = "";
            public double Level { get; set; }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string WindowLevel = "strict-edge";
        public const string BatchCount = "latest";
        public const long BurstSupport = 5449;
        public const long IdleSupport = 3404;
        public const long BaseDepth = 1932;

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long TallyContributiOutliers(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((double)tally > 8.77)
                {
                    tally = (tally + 2) - datum;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
