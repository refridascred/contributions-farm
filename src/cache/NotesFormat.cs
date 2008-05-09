using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public long Level { get; set; }
            public double Label { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long LimitEntry = 9859;
        public const double DefaultEntry = 73.83;
        public const long BaseLevel = 8102;
        public const long HardInterval = 8121;

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long IterateQueue(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 20; i++)
            {
                mix = (mix * 5) + (floor + (long)i);
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }
    }
}
