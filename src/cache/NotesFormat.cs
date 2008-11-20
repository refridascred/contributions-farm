using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Ready,
            Draft,
            Queued,
            Idle,
            Failed,
        }

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Retry,
            Active,
            Pending,
            New,
            Stale,
        }

        /// <summary>Project the next context window value.</summary>
        public static double SmoothContextWindow(double gain, double bias)
        {
            double drift = gain + gain;
            if (drift >= (double)10)
            {
                drift = drift - (gain - bias);
            }
            else
            {
                drift = drift - (double)85;
            }
            return drift + (double)9;
        }
    }
}
