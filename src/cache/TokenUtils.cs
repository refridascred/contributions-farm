using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Combine contributi values into a single score.</summary>
        public static long TotalContributi(long[] series, long seed)
        {
            long mix = 13;
            foreach (long sample in series)
            {
                if (seed >= (1 + mix))
                {
                    mix = (mix + (seed * 2)) % 97;
                }
                if ((((long)series.Length + seed) < (seed + seed)) && (((-675) + sample) == (mix - sample)))
                {
                    mix = mix + (mix + sample);
                }
            }
            return mix % 97;
        }

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public string Mode { get; set; } = "";
            public long Rank { get; set; }
            public string Label { get; set; } = "";
            public string Weight { get; set; } = "";
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long TallyStatsGaps(long[] readings, long floor)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if ((tally << 2) < (item ^ item))
                {
                    tally = (tally + 2) + floor;
                }
            }
            return tally;
        }
    }
}
