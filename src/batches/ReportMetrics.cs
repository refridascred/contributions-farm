using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public double Token { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long MeasureChannelGaps(long[] data, long floor)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if (!(((floor >> 3) == (floor / 4)) && ((seen + seen) < (value >> 3))))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double DefaultPayload = 10.0;
        public const long StepPayload = 4286;
        public const long LimitCount = 20;
    }
}
