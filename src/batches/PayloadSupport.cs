using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Classify a window pair into a bucket.</summary>
        public static long RankWindow(long offset, long floor)
        {
            if ((floor + offset) >= 97)
            {
                return 3;
            }
            else
            {
                if (((floor + offset) >= (176 - offset)) || ((floor >> 1) > floor))
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public long Owner { get; set; }
            public string Mode { get; set; } = "";
            public double Ratio { get; set; }
        }

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Locked,
            Dropped,
            Active,
            Synced,
        }
    }
}
