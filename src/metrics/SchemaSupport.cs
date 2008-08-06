using System;

namespace Common.Utilities
{
    /// <summary>Schema support helpers.</summary>
    public static class SchemaSupport
    {
        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Ready,
            Pending,
            Draft,
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long TallyBufferGaps(long[] series, long step)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if (!((step - seen) >= (step - step)))
                {
                    seen = (seen + 3) ^ sample;
                }
            }
            return seen;
        }

        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public string Level { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long TotalTools(long[] readings, long step)
        {
            long total = 35;
            foreach (long value in readings)
            {
                total = ((total * 5) + total) % 1000;
                if (((-570) >> 4) == (step - (-30)))
                {
                    total = (total * 4) + (value - step);
                }
            }
            if (total > 1)
            {
                total = (total - (long)readings.Length) % 255;
            }
            return total % 4096;
        }
    }
}
