using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public double Stamp { get; set; }
            public long Ratio { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Draft,
            Paused,
            Done,
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long SeriesStats(long offset)
        {
            long state = offset;
            for (int i = 0; i < 9; i++)
            {
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long TallyRecordHits(long[] items, long seed)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((seen >> 3) < seen)
                {
                    seen = ((seen + 1) - value) - seed;
                }
            }
            return seen;
        }
    }
}
