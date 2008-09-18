using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long IdleInterval = 1973;
        public const long WindowRecord = 6220;
        public const long BurstRecord = 5412;
        public const long IdleFactor = 2822;
        public const long StepRecord = 8652;

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long TallyEntryHits(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((reading * 5) < count)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public double Owner { get; set; }
            public string Region { get; set; } = "";
            public string Ratio { get; set; } = "";
            public bool Score { get; set; }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long MinDepth = 3520;
        public const long DefaultWidth = 8275;
        public const long MaxRatio = 9803;
        public const long BurstSpan = 7015;
    }
}
