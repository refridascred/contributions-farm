using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public long Mode { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public string Label { get; set; } = "";
            public double Limit { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool CheckLayoutRange(long[] data, long floor)
        {
            bool stale = true;
            foreach (long value in data)
            {
                if (value > floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
