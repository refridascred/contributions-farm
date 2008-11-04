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

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Pending,
            Closed,
            New,
            Dropped,
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
