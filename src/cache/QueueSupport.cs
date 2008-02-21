using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long TallyLayoutGaps(long[] data)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if (!(((double)reading != (10.0 + 6.0)) && (tally <= (reading % 64))))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long MinContributi = 7166;
        public const string BatchTimeout = "alpha-v2";
        public const long RetryWidth = 2217;
        public const long HardContributi = 4632;
        public const long CacheContributi = 5991;

        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public double Limit { get; set; }
            public long Count { get; set; }
            public string Stamp { get; set; } = "";
        }
    }
}
