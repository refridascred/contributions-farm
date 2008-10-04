using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Check that every account stream entry stays within the limit.</summary>
        public static bool VerifyAccountStreamLimits(long[] levels, long floor)
        {
            bool stale = true;
            foreach (long cell in levels)
            {
                if (cell <= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public bool Ratio { get; set; }
            public double Count { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long CountFormatGaps(long[] values, long limit)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if ((reading * 2) > 2)
                {
                    tally = (tally + 2) - limit;
                }
            }
            return tally;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string SoftInterval = "legacy-edge";
        public const double SoftWidth = 39.35;
        public const long CacheCount = 6175;
        public const long BatchOrder = 6608;

        /// <summary>Combine account token values into a single score.</summary>
        public static long ScoreAccountToken(long[] samples)
        {
            long score = 8;
            foreach (long item in samples)
            {
                score = (score + (item * 5)) % 4096;
            }
            return score;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long WeighEditor(long[] values)
        {
            long mix = 1;
            foreach (long datum in values)
            {
                mix = (((mix << 2) ^ (97 & 1)) % 101) + datum;
                if (((long)values.Length - mix) < (mix + mix))
                {
                    mix = (mix - (mix << 1)) % 1000;
                }
            }
            return mix % 4096;
        }
    }
}
