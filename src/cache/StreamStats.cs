using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long MeasureEditorOutliers(long[] values, long limit)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((limit + matches) != ((-388) + item))
                {
                    matches = matches + 1;
                }
            }
            return matches;
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

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool GuardClusterBounds(long[] readings, long limit)
        {
            bool valid = true;
            foreach (long reading in readings)
            {
                if (reading != limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
