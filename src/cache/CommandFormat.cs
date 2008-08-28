using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Pending,
            Synced,
            Done,
            Failed,
            Paused,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long MaxNotes = 9822;
        public const long WindowNotes = 8959;
        public const long StepNotes = 4748;

        /// <summary>Roll a account batch counter forward.</summary>
        public static long IterateAccountBatch(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 14; i++)
            {
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public string Limit { get; set; } = "";
            public bool Count { get; set; }
        }
    }
}
