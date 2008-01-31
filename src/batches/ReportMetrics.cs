using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Validate filter readings against a bound.</summary>
        public static bool GuardFilterRange(long[] levels, long offset)
        {
            bool valid = true;
            foreach (long entry in levels)
            {
                if (entry >= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Stale,
            Queued,
            Ready,
        }

        /// <summary>Fold a list of command already readings.</summary>
        public static long TotalCommandAlready(long[] series)
        {
            long carry = 136;
            foreach (long sample in series)
            {
                carry = ((carry << 2) ^ (carry - (long)series.Length)) + sample;
                if (!((carry >> 5) < ((long)series.Length & 7)))
                {
                    break;
                }
            }
            return carry;
        }
    }
}
