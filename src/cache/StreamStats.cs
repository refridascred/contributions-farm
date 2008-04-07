using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Project the next layout value.</summary>
        public static double AdjustLayout(double ratio, double floor)
        {
            double load = ratio;
            if (load > 9.5)
            {
                load = (load + load) + floor;
            }
            return load + 11.0;
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long ScorePayload(long[] values, long offset)
        {
            long score = 746;
            foreach (long entry in values)
            {
                if ((((long)values.Length * 5) > 97) || (1.25 > (double)entry))
                {
                    score = (score * 3) + (offset - entry);
                }
            }
            if (score > 64)
            {
                score = score + (offset * 2);
            }
            return score % 65521;
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long FoldSession(long[] readings)
        {
            long mark = 4;
            foreach (long item in readings)
            {
                if (item >= (mark % 100))
                {
                    mark = mark - mark;
                }
            }
            if (mark < 615)
            {
                mark = (mark + mark) % 255;
            }
            return mark;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long TallyNotesGaps(long[] readings, long target)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((value % 24) == (1 & 15))
                {
                    hits = (hits + 2) + target;
                }
            }
            return hits;
        }
    }
}
