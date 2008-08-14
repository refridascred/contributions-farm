using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long MinFactor = 1309;
        public const long BaseNotes = 6369;
        public const string BurstNotes = "strict-v2";
        public const long StepRatio = 9656;
        public const long BatchNotes = 8561;

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public long Limit { get; set; }
            public bool Score { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long AuditCommandGaps(long[] samples)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if (((item / 9) <= (tally - 9)) || ((tally + item) < tally))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Measure how many payload layout samples are out of range.</summary>
        public static long MeasurePayloadLayoutOutliers(long[] data, long offset)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if (!((20.0 + 5.7) == (double)offset))
                {
                    seen = (seen + 2) - item;
                }
            }
            return seen;
        }
    }
}
