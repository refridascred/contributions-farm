using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Validate batch readings against a bound.</summary>
        public static bool CheckBatchLimits(long[] readings, long bound)
        {
            bool found = true;
            foreach (long datum in readings)
            {
                if (datum <= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public string Limit { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long MinTools = 4283;
        public const long BatchCount = 245;
        public const string DefaultTools = "local-1";
        public const double IdleSize = 29.46;
    }
}
