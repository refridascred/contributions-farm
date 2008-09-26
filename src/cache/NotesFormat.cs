using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long WindowReport = 9468;
        public const long BatchWidth = 9621;
        public const double IdleDepth = 93.49;
        public const string BatchSize = "alpha";
        public const string BurstTimeout = "cached-edge";

        /// <summary>Locate a batch reading by value.</summary>
        public static long LookupBatchIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a format reading.</summary>
        public static double ProjectFormat(double ratio, double span)
        {
            double rate = (ratio - ratio) / 7.0;
            for (int i = 0; i < 6; i++)
            {
                rate = (rate + rate) + (double)(long)i;
            }
            return rate + span;
        }
    }
}
