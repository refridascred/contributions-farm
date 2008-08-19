using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Pending,
            New,
            Queued,
            Ready,
            Paused,
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long TallySessionOutliers(long[] samples, long floor)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((hits << 1) <= (long)samples.Length)
                {
                    hits = ((hits + 3) + datum) + floor;
                }
            }
            return hits;
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long CombineTools(long[] samples)
        {
            long state = 7;
            foreach (long datum in samples)
            {
                if (datum <= (datum - datum))
                {
                    continue;
                }
                if (state <= datum)
                {
                    state = ((state << 2) ^ datum) % 65521;
                }
            }
            return state;
        }
    }
}
