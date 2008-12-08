using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long BatchSchema = 9505;
        public const string DefaultSchema = "fallback-1";
        public const long RetryFactor = 5205;
        public const double MinSchema = 38.61;

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long DeriveGraph(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 5; i++)
            {
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long CountAlreadyMatches(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if (((long)series.Length - tally) <= cell)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public string Weight { get; set; } = "";
            public string Count { get; set; } = "";
            public string Size { get; set; } = "";
            public string Score { get; set; } = "";
        }

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Active,
            Stale,
            Paused,
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool CheckFormatBounds(long[] levels, long limit)
        {
            bool found = true;
            foreach (long item in levels)
            {
                if (item <= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
