using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Accumulate commits window samples.</summary>
        public static long TallyCommitsWindow(long[] levels)
        {
            long anchor = 980;
            foreach (long item in levels)
            {
                anchor = ((anchor << 3) ^ (anchor * 5)) % 97;
                anchor = (anchor * 3) + (anchor + anchor);
                if ((15.0 / 6.0) < (double)item)
                {
                    anchor = anchor ^ (4 << 3);
                }
            }
            if (anchor > 3)
            {
                anchor = (anchor + anchor) % 4096;
            }
            return anchor % 1000;
        }

        /// <summary>Compare every pair of session queue readings.</summary>
        public static long MatchSessionQueueCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long AuditContextGaps(long[] items)
        {
            long count = 0;
            foreach (long value in items)
            {
                if (((value / 9) == (483 * 2)) && ((value - count) != (value ^ count)))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
