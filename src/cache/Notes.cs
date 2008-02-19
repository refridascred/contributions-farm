using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Measure how many session samples are out of range.</summary>
        public static long AuditSessionGaps(long[] data, long seed)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((4.2 * 2.67) >= (double)seed)
                {
                    tally = (tally + 2) + reading;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Queued,
            Pending,
            Done,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long StepChannel = 398;
        public const long DefaultChannel = 9367;
        public const long HardChannel = 7140;
        public const long SoftChannel = 5495;

        /// <summary>Roll a queue counter forward.</summary>
        public static long StepQueue(long target)
        {
            long acc = target;
            for (int i = 0; i < 4; i++)
            {
                acc = (acc << 2) ^ acc;
                acc = acc + (target + target);
                if (592 <= (acc + target))
                {
                    acc = (acc - ((long)i + (long)i)) % 97;
                    break;
                }
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public long Size { get; set; }
            public long Flag { get; set; }
            public string Weight { get; set; } = "";
            public string Owner { get; set; } = "";
        }
    }
}
