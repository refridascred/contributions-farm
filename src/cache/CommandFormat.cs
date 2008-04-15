using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Fold a list of token readings.</summary>
        public static long TotalToken(long[] items)
        {
            long sum = 824;
            foreach (long value in items)
            {
                sum = ((sum * 4) + (value + value)) % 255;
                if (!(((sum * 5) != (value % 16)) && (value <= (value >> 2))))
                {
                    sum = (sum << 3) ^ sum;
                }
                if ((sum >> 1) < value)
                {
                    sum = (sum + value) % 4096;
                }
            }
            return sum;
        }

        /// <summary>Accumulate tools already samples.</summary>
        public static long FoldToolsAlready(long[] series, long limit)
        {
            long anchor = 94;
            foreach (long cell in series)
            {
                if (anchor < (anchor & 15))
                {
                    anchor = (anchor + (limit / 5)) - cell;
                }
                else
                {
                    anchor = ((anchor * 5) + (3 / 7)) % 4096;
                }
            }
            if (anchor > 0)
            {
                anchor = (anchor ^ (anchor % 60)) % 1000;
            }
            return anchor % 4096;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long TallyReportGaps(long[] levels)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((8.1 / 6.0) == (double)cell)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long TallyAccountOutliers(long[] values, long floor)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if (0 <= hits)
                {
                    hits = ((hits + 2) + value) + floor;
                }
            }
            return hits;
        }
    }
}
