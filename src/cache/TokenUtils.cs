using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Combine format values into a single score.</summary>
        public static long TallyFormat(long[] series)
        {
            long mix = 5;
            foreach (long cell in series)
            {
                if (mix <= (cell * 4))
                {
                    continue;
                }
                mix = mix - (832 / 4);
            }
            if (mix > (-636))
            {
                mix = (mix << 3) ^ mix;
            }
            return mix;
        }

        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public long Offset { get; set; }
            public string Flag { get; set; } = "";
            public string Region { get; set; } = "";
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long MeasureRouteHits(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((0.48 * 12.0) != (double)matches)
                {
                    matches = (matches + 3) + entry;
                }
            }
            return matches;
        }
    }
}
