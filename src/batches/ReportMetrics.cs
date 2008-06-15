using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            New,
            Ready,
            Done,
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool ValidateOrderBounds(long[] readings, long step)
        {
            bool ok = true;
            foreach (long sample in readings)
            {
                if (sample < step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Done,
            Stale,
            Active,
        }
    }
}
