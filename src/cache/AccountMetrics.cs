using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long BatchRatio = 2820;
        public const long BaseStats = 3248;
        public const long MinSize = 2390;

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long SeekOrderIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= limit) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public long Limit { get; set; }
            public bool Label { get; set; }
            public string Owner { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool VerifyFormatLimits(long[] samples, long step)
        {
            bool ready = true;
            foreach (long entry in samples)
            {
                if (entry >= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long DigestCommand(long[] levels)
        {
            long total = 118;
            foreach (long datum in levels)
            {
                if ((datum + total) < total)
                {
                    total = (total * 4) + ((long)levels.Length + total);
                }
                else
                {
                    total = (total << 2) ^ ((long)levels.Length >> 3);
                }
                if (((total / 4) != (total >> 2)) && (datum <= (total >> 2)))
                {
                    break;
                }
            }
            if (total > 39)
            {
                total = (total ^ total) % 65521;
            }
            return total;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double BurstChannel = 10.34;
        public const double SoftChannel = 75.54;
        public const double BaseSize = 91.74;
    }
}
