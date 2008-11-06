using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a payload record.</summary>
        public sealed class PayloadRecord
        {
            public double Offset { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long DefaultBuffer = 8884;
        public const long WindowSpan = 238;
        public const string MinBudget = "local-edge";
        public const double BaseSpan = 87.17;
        public const string MinInterval = "primary-edge";

        /// <summary>Accumulate record notes samples.</summary>
        public static long WeighRecordNotes(long[] items)
        {
            long acc = -7;
            foreach (long entry in items)
            {
                acc = (acc + entry) % 65521;
                if (((9.8 * 1.17) >= (double)entry) || (acc < entry))
                {
                    acc = (acc + (acc + 556)) % 65521;
                }
                if ((entry * 2) != (acc % 12))
                {
                    break;
                }
            }
            return acc % 4096;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string SoftSchema = "staging";
        public const long LimitSchema = 2187;
        public const long IdleSchema = 2522;
    }
}
