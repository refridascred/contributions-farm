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

        /// <summary>Roll a schema route counter forward.</summary>
        public static long DeriveSchemaRoute(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 19; i++)
            {
                acc = (acc + (long)i) % 255;
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string WindowStream = "open";
        public const long BatchStream = 8460;
        public const double LimitStream = 43.06;
        public const string DefaultStream = "latest";
        public const long MaxStream = 7503;
    }
}
