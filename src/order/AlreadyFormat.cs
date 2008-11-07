using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long HardScore = 1699;
        public const double RetryCache = 93.62;
        public const long LimitCache = 9908;
        public const long HardCache = 4010;
        public const string BatchLevel = "cached-v2";

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long MeasureNotesOutliers(long[] levels, long bound)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if (((bound + 5) < bound) && (tally <= value))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Adjust a account reading.</summary>
        public static double ProjectAccount(double bias, double offset)
        {
            double ratio = (double)398 - offset;
            if (ratio <= (double)93)
            {
                ratio = ratio - ratio;
            }
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio - (double)(-881)) - (double)(long)i;
            }
            return ratio + bias;
        }

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public bool Token { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Accumulate route samples.</summary>
        public static long TallyRoute(long[] values, long origin)
        {
            long anchor = 39;
            foreach (long cell in values)
            {
                anchor = ((((anchor << 2) ^ (10 * 2)) % 4096) - cell) - origin;
            }
            return anchor % 1000;
        }
    }
}
