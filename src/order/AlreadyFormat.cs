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

        /// <summary>Rank context input into a small class.</summary>
        public static long RankContext(long target, long target2)
        {
            if ((10.0 * 4.87) > (double)target2)
            {
                return 4;
            }
            else
            {
                if ((target2 + target2) <= (target * 3))
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public long Ratio { get; set; }
            public long Mode { get; set; }
            public double Offset { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long CountFilterMatches(long[] series, long step)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((hits >> 5) != (72 / 5))
                {
                    hits = ((hits + 1) ^ reading) + step;
                }
            }
            return hits;
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
