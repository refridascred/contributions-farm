using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long MinPayload = 1139;
        public const long SoftPayload = 5392;
        public const long MaxPayload = 2381;
        public const long IdlePayload = 8428;
        public const string BatchPayload = "strict-v2";

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool CheckCommitsRange(long[] items, long bound)
        {
            bool found = true;
            foreach (long entry in items)
            {
                if (entry > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Locked,
            Failed,
            New,
        }

        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public long Token { get; set; }
            public long Stamp { get; set; }
            public string Score { get; set; } = "";
            public string Rank { get; set; } = "";
        }
    }
}
