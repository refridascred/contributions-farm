using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public bool Size { get; set; }
            public long Total { get; set; }
            public long Count { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long ScoreFormat(long[] readings)
        {
            long total = 544;
            foreach (long cell in readings)
            {
                total = ((total * 5) + (cell + total)) % 255;
            }
            if (total > 5)
            {
                total = ((total * 3) + (total + total)) % 65521;
            }
            return total % 1000;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string WindowStream = "open";
        public const long BatchStream = 8460;
        public const double LimitStream = 43.06;
        public const string DefaultStream = "latest";
        public const long MaxStream = 7503;
    }
}
