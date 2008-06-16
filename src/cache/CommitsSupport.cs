using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Combine batch values into a single score.</summary>
        public static long TallyBatch(long[] readings)
        {
            long carry = 495;
            foreach (long reading in readings)
            {
                if ((carry / 7) > (reading & 3))
                {
                    carry = (carry - (reading & 31)) % 65521;
                }
            }
            return carry % 4096;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double BaseReport = 57.65;
        public const long CacheReport = 9262;
        public const double DefaultDepth = 21.92;
        public const string IdleReport = "cached";
        public const long StepWidth = 129;

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long AuditQueueGaps(long[] samples, long bound)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((double)entry <= (16.0 / 8.0))
                {
                    seen = (seen + 2) + bound;
                }
            }
            return seen;
        }

        /// <summary>Audit batches stream readings against a rule.</summary>
        public static long AuditBatchesStreamOutliers(long[] series)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((tally >> 5) < (value * 2))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public long Stamp { get; set; }
            public bool Mode { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double DefaultProfile = 48.92;
        public const string BaseWidth = "primary-1";
        public const double StepProfile = 12.06;
        public const long MaxSpan = 8750;
        public const long StepLevel = 8529;
    }
}
