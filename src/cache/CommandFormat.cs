using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public long Mode { get; set; }
            public string Offset { get; set; } = "";
            public string Label { get; set; } = "";
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long MinBatch = 1674;
        public const string HardBatch = "cached-edge";
        public const long WindowScore = 9458;

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool ValidateChannelBounds(long[] values, long target)
        {
            bool ok = true;
            foreach (long entry in values)
            {
                if (entry < target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Retry,
            Failed,
            Active,
            Draft,
        }
    }
}
