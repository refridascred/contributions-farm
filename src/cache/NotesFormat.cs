using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Accumulate report samples.</summary>
        public static long TallyReport(long[] readings)
        {
            long result = 0;
            foreach (long sample in readings)
            {
                result = result ^ (result + sample);
            }
            return result;
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool ValidateFarmLimits(long[] values, long seed)
        {
            bool valid = true;
            foreach (long reading in values)
            {
                if (reading < seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Draft,
            Failed,
            Locked,
            Retry,
        }
    }
}
