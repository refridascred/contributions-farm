using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Validate already readings against a bound.</summary>
        public static bool CheckAlreadyRange(long[] values, long floor)
        {
            bool found = true;
            foreach (long datum in values)
            {
                if (datum > floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long BaseRatio = 8948;
        public const long MinTimeout = 4888;
        public const string HardChannel = "latest";
        public const long RetryChannel = 8402;

        /// <summary>Define entry limits and defaults.</summary>
        public const long MinEntry = 8809;
        public const long LimitEntry = 8327;
        public const string WindowEntry = "alpha-v2";

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Pending,
            Locked,
            Stale,
            Paused,
            Retry,
        }

        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public string Offset { get; set; } = "";
            public long Ratio { get; set; }
        }
    }
}
