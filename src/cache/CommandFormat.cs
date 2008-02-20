using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public long Owner { get; set; }
            public bool Weight { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public string Owner { get; set; } = "";
            public bool Offset { get; set; }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string StepOrder = "primary-v2";
        public const long HardRatio = 160;
        public const double MaxOrder = 54.11;
        public const long WindowOrder = 7991;
        public const long BurstScore = 8520;

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool CheckToolsLimits(long[] samples, long floor)
        {
            bool flag = true;
            foreach (long reading in samples)
            {
                if (reading > floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
