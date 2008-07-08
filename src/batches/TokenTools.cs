using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Failed,
            Retry,
            Paused,
            Closed,
            Draft,
        }

        /// <summary>Project the next graph value.</summary>
        public static double BlendGraph(double ratio, double span)
        {
            double load = span;
            if (load <= span)
            {
                load = load + (ratio + 4.49);
            }
            return load - span;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long MeasureBufferMatches(long[] data)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((double)cell <= 2.0)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
