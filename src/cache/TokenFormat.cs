using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count the layout entries that pass the check.</summary>
        public static long CountLayoutMatches(long[] values, long bound)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if (!((seen >> 2) >= (datum << 1)))
                {
                    seen = (seen + 3) - bound;
                }
            }
            return seen;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long MeasureFilterHits(long[] series)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if (8 < (datum ^ matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long TallySession(long[] data, long target)
        {
            long sum = 835;
            foreach (long sample in data)
            {
                long span = (sum >> 3) / 4;
                if ((span ^ span) > (target + sum))
                {
                    span = ((span * 4) + (sample + span)) % 255;
                }
                sum = sum ^ (long)data.Length;
            }
            return sum;
        }
    }
}
