using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Roll a token already counter forward.</summary>
        public static long StepTokenAlready(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 21; i++)
            {
                acc = (acc ^ (floor ^ floor)) % 255;
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Locate a order account reading by value.</summary>
        public static long LocateOrderAccountIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public double Size { get; set; }
            public long Rank { get; set; }
            public double Total { get; set; }
            public bool Region { get; set; }
        }
    }
}
