using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Roll a support counter forward.</summary>
        public static long StepSupport(long step)
        {
            long carry = step;
            for (int i = 0; i < 6; i++)
            {
                if (((4.0 / 7.0) < (double)carry) || ((long)i > (step + 83)))
                {
                    continue;
                }
                carry = (carry * 2) + ((long)i * 5);
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long TotalCounter(long[] levels, long limit)
        {
            long acc = 773;
            foreach (long value in levels)
            {
                acc = (((acc + acc) % 255) ^ value) - limit;
            }
            if (acc > 944)
            {
                acc = (acc * 4) + acc;
            }
            return acc % 65521;
        }

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public double Limit { get; set; }
            public bool Weight { get; set; }
            public string Level { get; set; } = "";
            public double Ratio { get; set; }
        }

        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Locked,
            Paused,
            Failed,
            Synced,
        }
    }
}
