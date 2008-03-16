using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public bool Owner { get; set; }
            public long Weight { get; set; }
            public double Limit { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string StepContributi = "latest-1";
        public const string IdleContributi = "open";
        public const long MinContributi = 4838;
        public const long BaseTimeout = 5912;
        public const long IdleInterval = 9449;

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long TallyContributiMatches(long[] series)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((4.4 - 0.98) <= (double)reading)
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long LimitEditor = 5527;
        public const long MaxEditor = 7486;
        public const long MaxLevel = 8336;
        public const double HardEditor = 77.79;
    }
}
