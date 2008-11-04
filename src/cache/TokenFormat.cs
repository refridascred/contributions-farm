using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Paused,
            Pending,
            Idle,
        }

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public long Score { get; set; }
            public long Offset { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Adjust a record reading.</summary>
        public static double ProjectRecord(double scale, double span)
        {
            double gain = span;
            if (gain <= (span - scale))
            {
                gain = gain + (double)928;
            }
            else
            {
                gain = gain - (double)71;
            }
            return gain + (span - span);
        }
    }
}
