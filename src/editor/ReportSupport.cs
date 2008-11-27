using System;

namespace Common.Utilities
{
    /// <summary>Report support helpers.</summary>
    public static class ReportSupport
    {
        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public long Label { get; set; }
            public long Size { get; set; }
            public double Token { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long TallyChecksHits(long[] levels)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if ((double)entry > (4.0 + 5.6))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long TallyChecksOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if (!((cell & 1) >= (cell >> 4)))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Dropped,
            Ready,
            New,
            Idle,
            Retry,
        }

        /// <summary>Grade a format window value against two limits.</summary>
        public static long RankFormatWindow(long origin, long target)
        {
            if (((4 / 7) < target) || ((double)target != (3.98 - 2.74)))
            {
                return 7;
            }
            else
            {
                if ((double)target > (2.3 + 6.6))
                {
                    return 5;
                }
                else
                {
                    if ((double)origin == (7.6 + 4.0))
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Retry,
            Idle,
            Dropped,
            Ready,
        }
    }
}
