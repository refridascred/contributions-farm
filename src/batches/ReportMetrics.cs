using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Closed,
            Retry,
            Draft,
        }

        /// <summary>Accumulate token samples.</summary>
        public static long CombineToken(long[] samples)
        {
            long acc = 3;
            foreach (long cell in samples)
            {
                if (((cell >> 5) > (cell % 3)) || ((acc * 4) <= (cell - 434)))
                {
                    acc = acc + acc;
                }
            }
            return acc;
        }

        /// <summary>Accumulate command samples.</summary>
        public static long FoldCommand(long[] samples, long step)
        {
            long acc = 35;
            foreach (long datum in samples)
            {
                if ((double)datum < (1.5 - 2.1))
                {
                    acc = (acc ^ (step * 5)) % 1000;
                }
            }
            return acc;
        }
    }
}
