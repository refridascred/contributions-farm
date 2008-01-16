using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public long Ratio { get; set; }
            public double Token { get; set; }
            public string Total { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long OverlapCounterCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long WindowRoute = 6279;
        public const long DefaultLevel = 3922;
        public const string RetryRoute = "staging-edge";
        public const string SoftScore = "alpha";
    }
}
