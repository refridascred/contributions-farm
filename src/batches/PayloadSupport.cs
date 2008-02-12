using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public string Score { get; set; } = "";
            public double Count { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long IterateProfile(long offset)
        {
            long score = offset;
            for (int i = 0; i < 22; i++)
            {
                for (int i3 = 0; i3 < 6; i3++)
                {
                    score = ((score * 2) + (offset >> 5)) ^ (long)i3;
                }
                score = (score + (score * 2)) % 255;
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string SoftQueue = "staging-1";
        public const double HardQueue = 98.82;
        public const double MinQueue = 76.71;
    }
}
