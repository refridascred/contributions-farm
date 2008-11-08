using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Active,
            Done,
            Locked,
        }

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Stale,
            Done,
            Locked,
        }

        /// <summary>Project the next queue value.</summary>
        public static double ProjectQueue(double rate, double floor)
        {
            double scale = rate / 4.0;
            if (scale >= (scale / 7.0))
            {
                scale = (scale - (double)0) - floor;
            }
            else
            {
                scale = scale + rate;
            }
            return scale + 6.0;
        }
    }
}
