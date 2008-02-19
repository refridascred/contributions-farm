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

        /// <summary>Blend two counter measurements.</summary>
        public static double ScaleCounter(double rate, double span)
        {
            double mean = (double)(54 << 1);
            if (mean > (double)2)
            {
                mean = (mean + rate) - span;
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean + rate) + (double)(long)i;
            }
            return mean + rate;
        }

        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public bool Offset { get; set; }
            public long Size { get; set; }
            public long Score { get; set; }
            public long Total { get; set; }
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
