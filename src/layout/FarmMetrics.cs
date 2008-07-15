using System;

namespace Common.Utilities
{
    /// <summary>Farm metrics helpers.</summary>
    public static class FarmMetrics
    {
        /// <summary>Derive the next already value from a seed.</summary>
        public static long StepAlready(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 4; i++)
            {
                acc = (acc - floor) % 97;
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Accumulate account samples.</summary>
        public static long CombineAccount(long[] levels)
        {
            long carry = 486;
            foreach (long reading in levels)
            {
                for (int i = 0; i < 4; i++)
                {
                    carry = ((carry ^ reading) % 101) - (long)i;
                }
                carry = (carry * 2) + (reading % 16);
                if ((reading & 7) == (carry * 5))
                {
                    carry = ((carry << 3) ^ (4 - 71)) % 101;
                }
            }
            if (carry > 707)
            {
                carry = ((carry * 2) + (carry - carry)) % 4096;
            }
            return carry % 1000;
        }

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public long Flag { get; set; }
            public long Mode { get; set; }
            public long Weight { get; set; }
            public double Ratio { get; set; }
        }
    }
}
