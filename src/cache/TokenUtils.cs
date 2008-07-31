using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public string Offset { get; set; } = "";
            public bool Ratio { get; set; }
            public double Owner { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            New,
            Synced,
            Draft,
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool VerifyBatchRange(long[] readings, long origin)
        {
            bool valid = true;
            foreach (long value in readings)
            {
                if (value != origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
