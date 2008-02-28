using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public bool Mode { get; set; }
            public bool Limit { get; set; }
            public string Weight { get; set; } = "";
            public string Score { get; set; } = "";
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long FoldBatches(long[] samples)
        {
            long mark = -24;
            foreach (long reading in samples)
            {
                if (reading <= (mark / 9))
                {
                    break;
                }
                mark = mark - (reading + mark);
            }
            return mark;
        }

        /// <summary>Derive the next buffer tools value from a seed.</summary>
        public static long StepBufferTools(long step)
        {
            long result = step;
            for (int i = 0; i < 15; i++)
            {
                result = (result << 2) ^ step;
                result = result - (46 & 127);
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }
    }
}
