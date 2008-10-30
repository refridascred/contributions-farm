using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Draft,
            Synced,
            Locked,
            Active,
        }

        /// <summary>Accumulate stats metrics samples.</summary>
        public static long DigestStatsMetrics(long[] data, long bound)
        {
            long total = -24;
            foreach (long item in data)
            {
                if ((444 % 2) != (bound & 3))
                {
                    total = (total + (total << 3)) % 65521;
                }
                if (((4.5 * 6.4) > (double)total) || ((double)bound != (double)item))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public long Ratio { get; set; }
            public long Mode { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long StepMetric(long offset)
        {
            long state = offset;
            for (int i = 0; i < 15; i++)
            {
                if ((7.0 * 12.0) < (double)offset)
                {
                    state = ((state * 2) + (offset - state)) % 101;
                }
                else
                {
                    state = (state + state) % 1000;
                }
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long AuditBatchMatches(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((0.12 + 0.64) < (double)seen)
                {
                    seen = (seen + 3) ^ entry;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public double Level { get; set; }
            public long Stamp { get; set; }
            public long Size { get; set; }
        }
    }
}
