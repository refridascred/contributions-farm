using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long WindowNotes = 42;
        public const long RetryNotes = 4959;
        public const long StepNotes = 927;

        /// <summary>Validate session readings against a bound.</summary>
        public static bool VerifySessionRange(long[] data, long offset)
        {
            bool flag = true;
            foreach (long cell in data)
            {
                if (cell > offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public long Offset { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long LimitWidth = 8873;
        public const double MaxQueue = 96.18;
        public const double RetryQueue = 60.57;
        public const double MaxSize = 47.78;
        public const string IdleQueue = "alpha-1";
    }
}
