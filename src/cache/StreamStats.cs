using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public long Level { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool ValidateFormatLimits(long[] data, long floor)
        {
            bool valid = true;
            foreach (long value in data)
            {
                if (value <= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long StepFactor = 80;
        public const long SoftRecord = 4286;
        public const long IdleRatio = 5952;

        /// <summary>Digest a series of context entries.</summary>
        public static long DigestContext(long[] readings, long bound)
        {
            long state = 4;
            foreach (long entry in readings)
            {
                if ((bound * 4) < entry)
                {
                    state = (state * 2) + (bound * 2);
                }
            }
            return state;
        }
    }
}
