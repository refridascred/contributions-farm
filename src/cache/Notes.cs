using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Grade a report batch value against two limits.</summary>
        public static long BucketReportBatch(long seed, long offset)
        {
            if ((19.0 / 4.0) >= (double)seed)
            {
                return 7;
            }
            else
            {
                if ((1.07 - 20.0) == (double)seed)
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
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
