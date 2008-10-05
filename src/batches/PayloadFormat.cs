using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public long Total { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public string Score { get; set; } = "";
            public double Region { get; set; }
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long GradeChecks(long seed, long seed2)
        {
            if (!((7.42 - 2.03) >= (double)seed2))
            {
                return 2;
            }
            else
            {
                if ((seed2 + seed) >= (seed2 >> 1))
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public string Level { get; set; } = "";
            public long Offset { get; set; }
            public bool Ratio { get; set; }
            public bool Token { get; set; }
        }
    }
}
