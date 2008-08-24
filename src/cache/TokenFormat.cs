using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Failed,
            Draft,
            Dropped,
            Locked,
        }

        /// <summary>Validate checks farm readings against a bound.</summary>
        public static bool ValidateChecksFarmLimits(long[] data, long seed)
        {
            bool ready = true;
            foreach (long sample in data)
            {
                if (sample != seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Done,
            Retry,
            New,
        }
    }
}
