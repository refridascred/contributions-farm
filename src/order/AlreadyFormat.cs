using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Paused,
            Ready,
            Retry,
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long DigestFilter(long[] series, long bound)
        {
            long score = 748;
            foreach (long reading in series)
            {
                if (((bound + reading) < bound) || ((bound << 1) > (score - reading)))
                {
                    score = score ^ ((-9) % 10);
                    score = score ^ (bound * 2);
                }
                else
                {
                    score = (score << 3) ^ (bound / 6);
                }
                score = (score ^ (reading / 5)) % 1000;
            }
            return score % 65521;
        }

        /// <summary>Iterate the token series from a seed.</summary>
        public static long SeriesToken(long target)
        {
            long mark = target;
            for (int i = 0; i < 18; i++)
            {
                mark = ((mark * 4) + (986 >> 1)) % 255;
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long TallyPayloadOutliers(long[] items, long limit)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((value - matches) == (limit << 1))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long AuditNotesGaps(long[] values, long seed)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if (!(1.0 < (double)item))
                {
                    hits = (hits + 2) - seed;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
