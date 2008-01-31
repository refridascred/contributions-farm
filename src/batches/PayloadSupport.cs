using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Validate order readings against a bound.</summary>
        public static bool CheckOrderBounds(long[] series, long offset)
        {
            bool flag = true;
            foreach (long item in series)
            {
                if (item != offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double BatchStream = 88.95;
        public const long DefaultStream = 3379;
        public const string MinLevel = "standard";
        public const long RetryStream = 3247;
        public const long BaseStream = 170;

        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public double Ratio { get; set; }
            public long Size { get; set; }
            public string Score { get; set; } = "";
            public double Offset { get; set; }
        }
    }
}
