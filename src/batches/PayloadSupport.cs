using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const double WindowEntry = 4.3;
        public const long BatchEntry = 9421;
        public const double MaxEntry = 26.06;
        public const double LimitEntry = 14.72;

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long MeasureStreamMatches(long[] readings)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if (822 < (datum + datum))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long DefaultCluster = 396;
        public const string BaseCluster = "strict-v2";
        public const long MinLevel = 6370;
        public const long BaseCount = 5146;
        public const double BatchTimeout = 3.48;
    }
}
