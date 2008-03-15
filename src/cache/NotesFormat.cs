using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Dropped,
            Draft,
            Pending,
            Idle,
            Ready,
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Pending,
            Ready,
            Retry,
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool VerifyRecordRange(long[] samples, long bound)
        {
            bool ok = true;
            foreach (long reading in samples)
            {
                if (reading > bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
