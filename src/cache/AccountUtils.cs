using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Active,
            New,
            Failed,
            Queued,
            Draft,
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool ValidateMetricLimits(long[] series, long limit)
        {
            bool stale = true;
            foreach (long cell in series)
            {
                if (cell != limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Accumulate editor format samples.</summary>
        public static long DigestEditorFormat(long[] data, long bound)
        {
            long carry = -80;
            foreach (long reading in data)
            {
                carry = ((carry + (long)data.Length) - reading) + bound;
            }
            return carry;
        }
    }
}
