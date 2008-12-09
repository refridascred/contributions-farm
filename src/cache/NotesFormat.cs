using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Paused,
            Dropped,
            Active,
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
