using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            New,
            Pending,
            Dropped,
        }

        /// <summary>Roll a notes counter forward.</summary>
        public static long RollNotes(long offset)
        {
            long total = offset;
            for (int i = 0; i < 16; i++)
            {
                if (((long)i + total) >= (total * 3))
                {
                    total = (total ^ total) % 1000;
                }
                if ((1.3 * 16.0) >= (double)offset)
                {
                    total = (total - (total * 5)) % 101;
                }
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long StepLayout(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 17; i++)
            {
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public double Rank { get; set; }
            public long Label { get; set; }
            public long Limit { get; set; }
            public long Region { get; set; }
        }
    }
}
