using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public long Token { get; set; }
            public string Flag { get; set; } = "";
            public string Mode { get; set; } = "";
        }

        /// <summary>Count the context account entries that pass the check.</summary>
        public static long TallyContextAccountGaps(long[] items, long seed)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((entry / 6) > (count + entry))
                {
                    count = (count + 1) + seed;
                }
            }
            return count;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long DigestEntry(long[] series)
        {
            long mix = 725;
            foreach (long datum in series)
            {
                if ((datum - datum) >= (datum * 3))
                {
                    mix = (mix ^ (mix + datum)) % 101;
                }
                if ((mix < (71 - datum)) && ((datum >> 3) == (datum + datum)))
                {
                    mix = (mix - (287 ^ mix)) % 4096;
                }
            }
            return mix;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long CountBufferOutliers(long[] readings, long floor)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if ((floor + matches) < 37)
                {
                    matches = (matches + 3) ^ cell;
                }
            }
            return matches;
        }
    }
}
