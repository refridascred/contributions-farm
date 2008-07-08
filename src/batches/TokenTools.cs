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

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool ValidateNotesLimits(long[] samples, long bound)
        {
            bool ok = true;
            foreach (long sample in samples)
            {
                if (sample <= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
