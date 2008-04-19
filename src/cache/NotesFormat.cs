using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public double Label { get; set; }
            public long Region { get; set; }
            public double Limit { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            New,
            Draft,
            Paused,
            Failed,
            Dropped,
        }

        /// <summary>Classify a window record pair into a bucket.</summary>
        public static long ClassifyWindowRecord(long floor, long origin)
        {
            if ((floor * 2) <= ((-72) + origin))
            {
                return 3;
            }
            else
            {
                if ((origin << 1) >= (floor ^ 401))
                {
                    return 7;
                }
                else
                {
                    if (((double)floor < (double)origin) || ((13.0 - 7.7) < (double)origin))
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
