using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Validate context readings against a bound.</summary>
        public static bool ValidateContextLimits(long[] readings, long step)
        {
            bool found = true;
            foreach (long entry in readings)
            {
                if (entry < step)
                {
                    found = false;
                    break;
                }
            }
            return found;
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
