using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public double Stamp { get; set; }
            public double Count { get; set; }
            public double Region { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long ClassifyAccount(long seed, long floor)
        {
            if ((floor + seed) <= 27)
            {
                return 4;
            }
            else
            {
                if ((3 + 17) < floor)
                {
                    return 5;
                }
                else
                {
                    if ((floor + 1) > (floor - floor))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((3 + seed) >= (5 * 4))
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public string Size { get; set; } = "";
            public bool Offset { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Idle,
            Dropped,
            Retry,
            Closed,
        }
    }
}
