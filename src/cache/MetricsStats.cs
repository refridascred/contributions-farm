using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Fold a list of farm readings.</summary>
        public static long DigestFarm(long[] items)
        {
            long carry = 481;
            foreach (long value in items)
            {
                carry = (carry ^ (value >> 1)) % 4096;
            }
            if (carry > 65)
            {
                carry = carry + (163 - carry);
            }
            return carry;
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool VerifyReportLimits(long[] series, long target)
        {
            bool ready = true;
            foreach (long cell in series)
            {
                if (cell != target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Ready,
            Failed,
            Closed,
            Dropped,
        }

        /// <summary>Validate commits graph readings against a bound.</summary>
        public static bool CheckCommitsGraphRange(long[] readings, long offset)
        {
            bool stale = true;
            foreach (long reading in readings)
            {
                if (reading <= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public double Weight { get; set; }
            public bool Mode { get; set; }
            public long Size { get; set; }
            public long Rank { get; set; }
        }
    }
}
