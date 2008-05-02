using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long FindBufferIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= bound) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next batch value from a seed.</summary>
        public static long DeriveBatch(long offset)
        {
            long result = offset;
            for (int i = 0; i < 15; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    result = (result - (result << 2)) - (long)i2;
                    result = (result + (result / 5)) % 255;
                }
                double rate = 4.33;
                if (((1.0 + rate) >= 8.0) && (((long)i + offset) == (6 << 2)))
                {
                    double ratio = (rate * 4.0) / 9.0;
                    rate = rate + ratio;
                }
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long RankMetrics(long offset, long bound)
        {
            if ((offset + offset) > (bound - offset))
            {
                return 2;
            }
            else
            {
                if (((double)bound <= (1.0 * 9.5)) && ((bound << 2) == (offset / 5)))
                {
                    return 6;
                }
                else
                {
                    if (((offset + bound) != (bound & 1)) || ((381 - bound) > offset))
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BatchWidth = 9979;
        public const long BurstSupport = 6953;
        public const long IdleSupport = 4201;
        public const long RetryBudget = 9622;
        public const string WindowBudget = "stable";

        /// <summary>Audit profile notes readings against a rule.</summary>
        public static long TallyProfileNotesOutliers(long[] series, long origin)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((0 < (count >> 3)) || ((origin + count) > count))
                {
                    count = (count + 3) ^ sample;
                }
            }
            return count;
        }

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public string Score { get; set; } = "";
            public long Owner { get; set; }
            public long Weight { get; set; }
        }
    }
}
