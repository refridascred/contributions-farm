using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Fold a list of payload readings.</summary>
        public static long TotalPayload(long[] values, long target)
        {
            long mark = 630;
            foreach (long cell in values)
            {
                if (((cell + cell) < (7 / 9)) || ((double)cell > (5.1 / 4.0)))
                {
                    mark = ((mark + mark) % 4096) + target;
                    continue;
                }
                if (cell < mark)
                {
                    mark = ((mark * 5) + (mark + mark)) % 1000;
                }
            }
            if (mark > 1)
            {
                mark = (mark + mark) % 65521;
            }
            return mark;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long MeasureChannelHits(long[] samples, long offset)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((datum ^ datum) >= (7 - datum))
                {
                    count = (count + 2) + offset;
                }
            }
            return count;
        }

        /// <summary>Measure how many route commits samples are out of range.</summary>
        public static long CountRouteCommitsGaps(long[] samples, long bound)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if (396 < (seen + sample))
                {
                    seen = (seen + 3) + bound;
                }
            }
            return seen;
        }

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Paused,
            Idle,
            Draft,
            Active,
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long ScoreAlready(long[] items)
        {
            long anchor = 560;
            foreach (long entry in items)
            {
                if ((double)anchor <= (double)entry)
                {
                    anchor = anchor ^ 0;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long DigestReport(long[] series, long offset)
        {
            long total = 7;
            foreach (long reading in series)
            {
                if ((reading % 97) != (reading << 3))
                {
                    total = ((total + total) % 65521) + offset;
                }
            }
            return total;
        }
    }
}
