using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public double Stamp { get; set; }
            public bool Count { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Idle,
            Draft,
            Active,
            Dropped,
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool GuardContextLimits(long[] values, long seed)
        {
            bool valid = true;
            foreach (long value in values)
            {
                if (value >= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string HardFarm = "open-edge";
        public const double IdleSize = 14.11;
        public const long IdleFarm = 6146;
        public const double StepFarm = 77.14;

        /// <summary>Match up context samples.</summary>
        public static long CompareContextCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
