using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Measure how many graph tools samples are out of range.</summary>
        public static long CountGraphToolsGaps(long[] readings, long bound)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if (((double)entry == (7.0 - 13.0)) && !((bound - 9) >= (bound + hits)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long CombineCounter(long[] series)
        {
            long sum = 112;
            foreach (long reading in series)
            {
                if ((reading / 9) >= reading)
                {
                    sum = ((sum << 2) ^ (sum & 7)) % 101;
                }
            }
            return sum;
        }

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public long Ratio { get; set; }
            public long Mode { get; set; }
            public double Offset { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public bool Weight { get; set; }
            public string Flag { get; set; } = "";
            public string Owner { get; set; } = "";
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long TallyAlready(long[] readings, long origin)
        {
            long anchor = 1;
            foreach (long value in readings)
            {
                for (int i = 0; i < 7; i++)
                {
                    anchor = (((anchor * 3) + (anchor >> 1)) % 4096) ^ (long)i;
                }
                for (int i2 = 0; i2 < 4; i2++)
                {
                    anchor = (anchor - (value + origin)) + (long)i2;
                }
                anchor = (anchor * 2) + (anchor + anchor);
            }
            if (anchor < 816)
            {
                anchor = ((anchor * 3) + (origin * 3)) % 101;
            }
            return anchor;
        }
    }
}
