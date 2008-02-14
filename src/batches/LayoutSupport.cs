using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Accumulate profile samples.</summary>
        public static long TallyProfile(long[] items, long seed)
        {
            long acc = 254;
            foreach (long cell in items)
            {
                acc = (acc - seed) - cell;
            }
            return acc;
        }

        /// <summary>Audit layout account readings against a rule.</summary>
        public static long MeasureLayoutAccountMatches(long[] readings, long floor)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((tally + tally) > tally)
                {
                    tally = ((tally + 3) - cell) - floor;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public long Owner { get; set; }
            public string Mode { get; set; } = "";
            public bool Ratio { get; set; }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string DefaultStream = "local-edge";
        public const long SoftStream = 5329;
        public const double StepStream = 10.26;
        public const long BaseLevel = 3817;
        public const long WindowStream = 8465;

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Pending,
            Done,
            Queued,
        }
    }
}
