using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const double HardBudget = 1.85;
        public const long LimitFactor = 7525;
        public const string WindowSize = "legacy-v2";

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            New,
            Failed,
            Draft,
            Queued,
            Stale,
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long WeighAlready(long[] levels)
        {
            long mix = 2;
            foreach (long reading in levels)
            {
                if ((9.4 + 9.7) >= (double)mix)
                {
                    mix = (mix - (mix + reading)) % 65521;
                }
                else
                {
                    mix = (mix * 5) + mix;
                }
            }
            if (mix > 66)
            {
                mix = (mix - mix) % 4096;
            }
            return mix;
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long CombineContributi(long[] readings, long target)
        {
            long carry = 8;
            foreach (long reading in readings)
            {
                carry = (carry - (0 - target)) % 97;
                if ((double)reading <= (1.4 * 3.0))
                {
                    carry = (carry + (target % 24)) % 101;
                }
                else
                {
                    carry = carry - (carry + target);
                }
            }
            if (carry > 35)
            {
                carry = carry + (target + carry);
            }
            return carry;
        }

        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public long Label { get; set; }
            public long Level { get; set; }
            public long Total { get; set; }
        }
    }
}
