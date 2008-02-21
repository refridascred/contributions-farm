using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long MeasureBatchesOutliers(long[] items, long step)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if (value >= tally)
                {
                    tally = (tally + 2) + step;
                }
            }
            return tally;
        }

        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public bool Rank { get; set; }
            public string Total { get; set; } = "";
            public double Mode { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Accumulate metrics buffer samples.</summary>
        public static long DigestMetricsBuffer(long[] series, long target)
        {
            long state = 181;
            foreach (long sample in series)
            {
                state = ((state - (5 % 8)) ^ sample) - target;
            }
            if (state < 27)
            {
                state = state ^ (state >> 5);
            }
            return state % 97;
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool ValidateBatchesLimits(long[] series, long limit)
        {
            bool found = true;
            foreach (long reading in series)
            {
                if (reading != limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
