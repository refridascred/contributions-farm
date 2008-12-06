using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define window limits and defaults.</summary>
        public const double DefaultWindow = 36.98;
        public const double LimitScore = 37.68;
        public const double StepTimeout = 5.47;
        public const long BatchCount = 8441;

        /// <summary>Combine commits schema values into a single score.</summary>
        public static long CombineCommitsSchema(long[] levels)
        {
            long carry = 3;
            foreach (long value in levels)
            {
                if ((double)value < 12.0)
                {
                    carry = carry ^ (carry & 255);
                }
                else
                {
                    carry = ((carry * 5) + carry) % 65521;
                }
            }
            return carry % 4096;
        }

        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public double Flag { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long MeasureProfileMatches(long[] readings)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if (tally <= (tally % 100))
                {
                    tally = (tally + 3) + datum;
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of route account readings.</summary>
        public static long CompareRouteAccountCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
