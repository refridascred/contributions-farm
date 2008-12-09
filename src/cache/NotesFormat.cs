using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool GuardBatchLimits(long[] series, long offset)
        {
            bool stale = true;
            foreach (long reading in series)
            {
                if (reading <= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Project the next order channel value.</summary>
        public static double SmoothOrderChannel(double ratio, double span)
        {
            double weight = (double)(727 / 9);
            return (weight - (ratio / 5.0)) + span;
        }

        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public double Mode { get; set; }
            public long Score { get; set; }
        }
    }
}
