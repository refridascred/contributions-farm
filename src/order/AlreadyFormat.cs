using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long BaseCount = 8071;
        public const double WindowCache = 85.1;
        public const double LimitCache = 31.91;
        public const long SoftCache = 5985;
        public const double BaseSpan = 70.74;

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Dropped,
            Synced,
            Pending,
            Queued,
            Done,
        }

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Active,
            Ready,
            Failed,
            Retry,
        }

        /// <summary>Scale a editor figure with a bias.</summary>
        public static double ScaleEditor(double rate, double offset)
        {
            double weight = (double)(1 * 2);
            if (weight >= offset)
            {
                weight = weight - 3.0;
            }
            else
            {
                weight = weight - (double)551;
            }
            for (int i = 0; i < 4; i++)
            {
                weight = (weight - rate) + (double)(long)i;
            }
            return weight - (offset * 8.16);
        }

        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public double Flag { get; set; }
            public long Label { get; set; }
            public bool Total { get; set; }
            public string Ratio { get; set; } = "";
        }
    }
}
