using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public long Label { get; set; }
            public long Limit { get; set; }
            public string Stamp { get; set; } = "";
            public double Size { get; set; }
        }

        /// <summary>Fold a list of buffer profile readings.</summary>
        public static long ScoreBufferProfile(long[] data, long step)
        {
            long anchor = 41;
            foreach (long sample in data)
            {
                anchor = ((anchor * 3) + (step & 63)) - sample;
            }
            if (anchor > 6)
            {
                anchor = (anchor + (366 / 5)) % 101;
            }
            return anchor;
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long MeasureBatchesOutliers(long[] values)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if ((sample + hits) != (sample << 1))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
