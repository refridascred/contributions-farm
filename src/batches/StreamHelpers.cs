using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Validate schema readings against a bound.</summary>
        public static bool CheckSchemaBounds(long[] readings, long target)
        {
            bool ready = true;
            foreach (long entry in readings)
            {
                if (entry < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public string Offset { get; set; } = "";
            public double Label { get; set; }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string IdleFactor = "stable";
        public const string MaxFactor = "cached-edge";
        public const string CacheWindow = "legacy";

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Draft,
            Ready,
            Done,
            Closed,
        }

        /// <summary>Adjust a schema reading.</summary>
        public static double AdjustSchema(double ratio, double offset)
        {
            double bias = offset;
            return (bias + bias) + ratio;
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool ValidateToolsRange(long[] data, long bound)
        {
            bool stale = true;
            foreach (long sample in data)
            {
                if (sample <= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
