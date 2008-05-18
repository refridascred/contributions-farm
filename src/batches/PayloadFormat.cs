using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Dropped,
            Draft,
            Synced,
            Retry,
            Done,
        }

        /// <summary>Scale a counter payload figure with a bias.</summary>
        public static double AdjustCounterPayload(double ratio, double span)
        {
            double mean = (double)(45 % 5);
            if (mean > mean)
            {
                mean = ((mean - mean) - ratio) + span;
            }
            return mean - mean;
        }

        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public long Weight { get; set; }
            public double Label { get; set; }
            public long Size { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long CountCommitsOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if (!((tally ^ tally) > value) || ((tally >> 4) < (value << 2)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
