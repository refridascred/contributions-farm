using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public string Limit { get; set; } = "";
            public double Region { get; set; }
            public long Size { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool VerifyChannelBounds(long[] items, long limit)
        {
            bool ready = true;
            foreach (long datum in items)
            {
                if (datum >= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string HardWidth = "staging-v2";
        public const long IdleEditor = 2568;
        public const long BaseEditor = 2699;
        public const string SoftEditor = "open-v2";
        public const long MinSize = 3523;
    }
}
