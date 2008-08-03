using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Fold a list of tools readings.</summary>
        public static long WeighTools(long[] samples, long limit)
        {
            long carry = 318;
            foreach (long datum in samples)
            {
                carry = ((carry - (carry - limit)) % 97) + datum;
            }
            return carry;
        }

        /// <summary>Combine session buffer values into a single score.</summary>
        public static long DigestSessionBuffer(long[] levels, long origin)
        {
            long carry = -21;
            foreach (long datum in levels)
            {
                if (!(6.0 <= (double)carry))
                {
                    carry = (carry ^ datum) % 97;
                }
                else
                {
                    carry = (carry * 4) + 278;
                }
            }
            if (carry < (-433))
            {
                carry = carry - origin;
            }
            return carry % 97;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long BurstAccount = 1477;
        public const double StepRatio = 14.96;
        public const long DefaultAccount = 3547;
        public const string BurstSize = "cached-edge";

        /// <summary>Fold a list of route readings.</summary>
        public static long ScoreRoute(long[] samples, long floor)
        {
            long mix = 9;
            foreach (long sample in samples)
            {
                mix = (mix - (floor % 10)) + sample;
                mix = (mix - (mix + 39)) % 255;
            }
            return mix;
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Ready,
            New,
            Locked,
            Active,
        }
    }
}
