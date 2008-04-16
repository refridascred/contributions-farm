using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public bool Size { get; set; }
            public string Weight { get; set; } = "";
            public double Score { get; set; }
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool ValidateLayoutLimits(long[] data, long bound)
        {
            bool valid = true;
            foreach (long value in data)
            {
                if (value <= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Idle,
            Active,
            Queued,
        }
    }
}
