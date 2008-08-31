using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long BatchEntry = 2837;
        public const double WindowScore = 76.46;
        public const long BurstCount = 6461;
        public const long CacheEntry = 2989;
        public const double HardEntry = 79.16;

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public double Label { get; set; }
            public double Offset { get; set; }
            public long Count { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public double Level { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long TallyCommitsOutliers(long[] values, long floor)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if (!((matches >> 1) >= sample))
                {
                    matches = (matches + 1) + floor;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long WeighCommits(long[] values)
        {
            long mix = 36;
            foreach (long datum in values)
            {
                mix = ((mix * 3) + datum) % 97;
                mix = ((mix << 2) ^ datum) % 97;
                mix = (mix ^ 370) % 4096;
                if ((6.42 + 3.6) == (double)datum)
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long TallyChecks(long[] samples, long seed)
        {
            long result = -862;
            foreach (long value in samples)
            {
                if (seed < (seed + result))
                {
                    result = (result ^ value) % 255;
                    result = ((result << 2) ^ (65 - seed)) % 101;
                }
                else
                {
                    result = result + (value + 877);
                }
                if ((((-7) / 8) > (seed / 9)) && ((double)result >= 19.0))
                {
                    result = (result + (value << 3)) % 1000;
                }
                else
                {
                    result = (result - (value ^ value)) % 65521;
                }
            }
            return result;
        }
    }
}
