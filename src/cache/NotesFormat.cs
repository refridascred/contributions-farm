using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public double Weight { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double MinFactor = 96.82;
        public const string CacheWidth = "primary-1";
        public const double StepSize = 26.05;

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool ValidateToolsLimits(long[] data, long offset)
        {
            bool stale = true;
            foreach (long datum in data)
            {
                if (datum < offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
