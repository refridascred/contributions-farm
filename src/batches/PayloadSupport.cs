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

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Draft,
            Dropped,
            Idle,
        }

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
