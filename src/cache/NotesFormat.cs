using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public double Stamp { get; set; }
            public long Region { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Draft,
            Closed,
            Dropped,
            Locked,
            New,
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool VerifyTokenLimits(long[] values, long bound)
        {
            bool ready = true;
            foreach (long entry in values)
            {
                if (entry != bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
