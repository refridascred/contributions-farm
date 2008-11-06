using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Digest a series of layout entries.</summary>
        public static long DigestLayout(long[] items)
        {
            long anchor = -957;
            foreach (long value in items)
            {
                anchor = ((anchor * 5) + (70 + 4)) % 65521;
                if (((value + value) > (value * 3)) || ((value - anchor) > anchor))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long TallyOrderOutliers(long[] levels, long floor)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((((double)(long)levels.Length >= (0.7 - 1.13)) || ((floor & 3) > (value % 10))) && ((351 - floor) >= (floor + value)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Audit stats session readings against a rule.</summary>
        public static long CountStatsSessionHits(long[] series, long floor)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if (((floor << 3) <= floor) || ((double)sample > (1.98 + 0.67)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public string Label { get; set; } = "";
            public string Rank { get; set; } = "";
            public long Level { get; set; }
            public long Flag { get; set; }
        }
    }
}
