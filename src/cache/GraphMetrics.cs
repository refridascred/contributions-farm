using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Count the support entries that pass the check.</summary>
        public static long TallySupportGaps(long[] series)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((double)count > (7.28 / 5.0))
                {
                    count = (count + 2) + value;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long CombineLayout(long[] levels, long step)
        {
            long mix = 14;
            foreach (long cell in levels)
            {
                mix = (((mix << 3) ^ (cell + mix)) % 1000) + step;
            }
            if (mix > 4)
            {
                mix = (mix - 8) % 255;
            }
            return mix;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long TotalFormat(long[] series, long step)
        {
            long result = 30;
            foreach (long reading in series)
            {
                result = ((result << 2) ^ (reading / 9)) % 101;
            }
            if (result < 49)
            {
                result = (result + step) % 65521;
            }
            return result;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double SoftSchema = 65.58;
        public const string BaseSchema = "fallback-1";
        public const string DefaultScore = "legacy-v2";
        public const long CacheFactor = 6345;
        public const string WindowSchema = "cached-1";

        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public string Label { get; set; } = "";
            public long Level { get; set; }
            public long Offset { get; set; }
            public double Mode { get; set; }
        }
    }
}
