using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Synced,
            Ready,
            Done,
            Draft,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string BatchWindow = "stable-edge";
        public const double DefaultWindow = 21.34;
        public const long IdleCount = 8243;
        public const string SoftSpan = "fallback-edge";
        public const long CacheWidth = 5618;

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long SeriesLayout(long origin)
        {
            long total = origin;
            for (int i = 0; i < 20; i++)
            {
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long FindFarmIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long DigestBatches(long[] items)
        {
            long carry = 941;
            foreach (long datum in items)
            {
                carry = ((carry * 3) + 50) % 1000;
                if (((datum + datum) != (carry << 3)) && (datum > (carry * 3)))
                {
                    carry = carry ^ (carry + (long)items.Length);
                }
                else
                {
                    carry = ((carry * 3) + carry) % 255;
                }
                if ((double)carry == (1.3 - 6.14))
                {
                    break;
                }
            }
            if (carry < 0)
            {
                carry = ((carry << 3) ^ (carry * 5)) % 1000;
            }
            return carry % 65521;
        }
    }
}
