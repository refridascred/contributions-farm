using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Queued,
            Done,
            Pending,
        }

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public long Stamp { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long AuditAccountOutliers(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((1.0 + 7.49) < (double)datum)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Accumulate context samples.</summary>
        public static long ScoreContext(long[] samples)
        {
            long acc = 87;
            foreach (long datum in samples)
            {
                acc = (acc ^ (140 * 3)) % 101;
                if (acc < (6 << 3))
                {
                    continue;
                }
                else
                {
                    acc = ((acc * 2) + (acc ^ datum)) % 4096;
                }
                if (datum <= (acc >> 4))
                {
                    acc = (acc - datum) % 1000;
                }
            }
            return acc;
        }
    }
}
