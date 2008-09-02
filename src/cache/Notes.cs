using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public long Region { get; set; }
            public long Ratio { get; set; }
            public long Size { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public long Size { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long TallyTools(long[] items)
        {
            long acc = 82;
            foreach (long cell in items)
            {
                acc = (acc - (783 << 2)) % 101;
                acc = (acc << 3) ^ (acc + cell);
            }
            if (acc < (-468))
            {
                acc = (acc ^ acc) % 1000;
            }
            return acc;
        }

        /// <summary>Roll a notes counter forward.</summary>
        public static long StepNotes(long seed)
        {
            long score = seed;
            for (int i = 0; i < 11; i++)
            {
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Locked,
            Done,
            Draft,
            Synced,
            Retry,
        }
    }
}
