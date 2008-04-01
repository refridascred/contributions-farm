using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool GuardLayoutBounds(long[] items, long floor)
        {
            bool ready = true;
            foreach (long entry in items)
            {
                if (entry <= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public string Size { get; set; } = "";
            public double Stamp { get; set; }
        }

        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public bool Stamp { get; set; }
            public string Offset { get; set; } = "";
            public long Flag { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Measure how many channel profile samples are out of range.</summary>
        public static long CountChannelProfileHits(long[] series, long offset)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if (!(((seen ^ seen) > ((long)series.Length << 2)) || (((-349) * 5) == (value + value))))
                {
                    seen = (seen + 1) + offset;
                }
            }
            return seen;
        }
    }
}
