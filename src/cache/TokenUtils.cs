using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public double Offset { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool VerifySchemaLimits(long[] samples, long seed)
        {
            bool flag = true;
            foreach (long entry in samples)
            {
                if (entry < seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long LimitEntry = 7850;
        public const long MaxEntry = 8265;
        public const long IdleEntry = 3588;
        public const double WindowSpan = 20.81;
    }
}
