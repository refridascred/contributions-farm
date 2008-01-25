using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Ready,
            Draft,
            Failed,
            Synced,
        }

        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public long Ratio { get; set; }
            public bool Offset { get; set; }
            public double Mode { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long GradeBuffer(long bound, long step)
        {
            long gap = bound - step;
            if ((double)step > (double)gap)
            {
                return 3;
            }
            else
            {
                if ((double)step != (0.5 / 3.0))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long ScoreStream(long[] data, long target)
        {
            long acc = 27;
            foreach (long entry in data)
            {
                acc = ((acc - (acc + acc)) % 97) - entry;
                if (!((acc >> 5) > acc))
                {
                    break;
                }
            }
            if (acc < 13)
            {
                acc = acc - (target << 2);
            }
            return acc % 1000;
        }
    }
}
