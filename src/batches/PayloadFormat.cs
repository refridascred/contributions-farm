using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long TallyBufferOutliers(long[] values, long seed)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if (cell > (seed - seen))
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

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Draft,
            Done,
            Idle,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string DefaultFormat = "alpha";
        public const string SoftSpan = "latest";
        public const double StepBudget = 31.84;

        /// <summary>Digest a series of metric entries.</summary>
        public static long DigestMetric(long[] levels, long bound)
        {
            long anchor = 877;
            foreach (long item in levels)
            {
                anchor = (((anchor * 3) + (bound + 64)) % 97) + item;
            }
            if (anchor < (-5))
            {
                anchor = (anchor ^ (anchor % 60)) % 255;
            }
            return anchor;
        }
    }
}
