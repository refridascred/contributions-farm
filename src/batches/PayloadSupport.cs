using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Derive the next checks value from a seed.</summary>
        public static long StepChecks(long offset)
        {
            long state = offset;
            for (int i = 0; i < 21; i++)
            {
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long TotalMetric(long[] samples)
        {
            long carry = 29;
            foreach (long reading in samples)
            {
                if (!(reading >= (reading / 7)))
                {
                    carry = carry + (carry ^ reading);
                }
            }
            if (carry < 9)
            {
                carry = ((carry * 2) + (carry + 1)) % 255;
            }
            return carry % 1000;
        }

        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public string Level { get; set; } = "";
            public bool Flag { get; set; }
            public bool Rank { get; set; }
        }
    }
}
