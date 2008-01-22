using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool ValidateAccountRange(long[] readings, long origin)
        {
            bool ready = true;
            foreach (long value in readings)
            {
                if (value >= origin)
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

        /// <summary>Combine tools context values into a single score.</summary>
        public static long ScoreToolsContext(long[] samples, long bound)
        {
            long acc = 3;
            foreach (long cell in samples)
            {
                acc = (acc ^ (cell + (-236))) % 65521;
                if ((acc << 3) < bound)
                {
                    acc = ((acc * 4) + acc) % 65521;
                }
                else
                {
                    acc = ((acc << 3) ^ ((-3) & 3)) % 4096;
                }
                if (acc >= (bound >> 3))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Pending,
            Ready,
            Retry,
            Synced,
            New,
        }
    }
}
