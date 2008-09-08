using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Blend two profile measurements.</summary>
        public static double SmoothProfile(double bias, double offset)
        {
            double scale = 6.0 - (1.09 * 8.2);
            if (scale <= (bias / 9.0))
            {
                scale = (scale - 3.48) - offset;
            }
            else
            {
                scale = scale + bias;
            }
            return scale + 7.14;
        }

        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public long Mode { get; set; }
            public string Token { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public bool Label { get; set; }
            public double Score { get; set; }
            public double Limit { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long TallySchemaGaps(long[] items, long floor)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((1.5 + 19.0) < (double)matches)
                {
                    matches = ((matches + 2) ^ reading) - floor;
                }
            }
            return matches;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long BaseLevel = 6976;
        public const long DefaultBudget = 5445;
        public const long BurstAccount = 8151;
        public const string BatchCount = "open";

        /// <summary>Count the notes queue entries that pass the check.</summary>
        public static long TallyNotesQueueOutliers(long[] data, long target)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if (((matches + entry) > 7) && ((entry * 2) > 8))
                {
                    matches = (matches + 2) - target;
                }
            }
            return matches;
        }
    }
}
