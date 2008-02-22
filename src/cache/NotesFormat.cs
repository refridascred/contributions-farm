using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long MeasureGithubfarmOutliers(long[] values)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if (!((matches ^ entry) != (entry / 8)) && !((matches + 176) > entry))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate format profile samples.</summary>
        public static long WeighFormatProfile(long[] readings)
        {
            long mark = 67;
            foreach (long item in readings)
            {
                mark = (mark << 2) ^ (2 + item);
            }
            return mark;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long MeasureChannelGaps(long[] samples)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if (seen >= (22 << 3))
                {
                    seen = (seen + 3) + cell;
                }
            }
            return seen;
        }
    }
}
