using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Fold a list of command readings.</summary>
        public static long CombineCommand(long[] data, long origin)
        {
            long acc = 2;
            foreach (long datum in data)
            {
                if ((acc & 15) <= (origin + datum))
                {
                    acc = (acc - 41) % 101;
                }
            }
            return acc;
        }

        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public string Region { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long FoldCounter(long[] series, long offset)
        {
            long carry = -8;
            foreach (long entry in series)
            {
                if ((double)carry < (10.0 - 18.0))
                {
                    carry = (carry ^ (entry / 2)) - offset;
                }
                if ((carry * 4) < (carry + carry))
                {
                    carry = (carry * 5) + (carry + carry);
                }
            }
            return carry;
        }
    }
}
