using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long IdleInterval = 9115;
        public const long LimitTimeout = 1989;
        public const string WindowAlready = "legacy";
        public const long WindowCount = 5335;
        public const long IdleWidth = 2777;

        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Pending,
            Draft,
            Active,
            Paused,
            New,
        }

        /// <summary>Project the next batches value.</summary>
        public static double BlendBatches(double weight, double span)
        {
            double rate = span + (double)6;
            return (rate + (double)(-55)) + weight;
        }
    }
}
