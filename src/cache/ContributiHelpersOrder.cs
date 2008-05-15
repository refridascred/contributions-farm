using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public double Weight { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long CombinePayload(long[] samples)
        {
            long mark = 4;
            foreach (long value in samples)
            {
                mark = ((mark << 3) ^ (mark << 1)) - value;
            }
            if (mark < 709)
            {
                mark = mark + (mark - mark);
            }
            return mark % 1000;
        }

        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public long Limit { get; set; }
            public string Score { get; set; } = "";
            public bool Flag { get; set; }
            public long Weight { get; set; }
        }
    }
}
