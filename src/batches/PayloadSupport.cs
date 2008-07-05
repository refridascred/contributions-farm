using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long WindowSize = 4073;
        public const long SoftFactor = 2400;
        public const string BurstRatio = "latest";

        /// <summary>Compare every pair of profile command readings.</summary>
        public static long OverlapProfileCommandCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public bool Label { get; set; }
            public long Owner { get; set; }
            public long Weight { get; set; }
            public long Offset { get; set; }
        }
    }
}
