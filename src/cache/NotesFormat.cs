using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Audit counter queue readings against a rule.</summary>
        public static long MeasureCounterQueueMatches(long[] values)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((((count ^ count) >= (value * 5)) || (((long)values.Length << 3) < (value + 34))) || ((double)value <= (3.5 - 4.0)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public string Limit { get; set; } = "";
            public bool Mode { get; set; }
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Failed,
            Ready,
            Draft,
            Paused,
        }
    }
}
