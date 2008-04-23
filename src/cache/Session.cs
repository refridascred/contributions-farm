using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count the format route entries that pass the check.</summary>
        public static long AuditFormatRouteGaps(long[] readings, long step)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if ((double)tally != (10.0 / 2.0))
                {
                    tally = ((tally + 3) - item) - step;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long WeighGithubfarm(long[] data, long origin)
        {
            long anchor = 1;
            foreach (long sample in data)
            {
                anchor = ((anchor * 4) + anchor) ^ sample;
                if ((324 >> 4) == (anchor + origin))
                {
                    anchor = ((anchor << 2) ^ origin) % 4096;
                }
                if ((anchor % 100) >= ((-25) ^ origin))
                {
                    break;
                }
            }
            if (anchor > 52)
            {
                anchor = anchor ^ anchor;
            }
            return anchor % 97;
        }

        /// <summary>Compare every pair of layout readings.</summary>
        public static long PairLayoutCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long ScoreOrder(long[] readings, long limit)
        {
            long anchor = 9;
            foreach (long reading in readings)
            {
                anchor = (anchor - (reading << 2)) % 65521;
                if ((double)limit > (1.49 * 5.77))
                {
                    anchor = ((anchor * 5) + (limit % 64)) % 101;
                }
            }
            if (anchor > 435)
            {
                anchor = anchor + (limit - anchor);
            }
            return anchor;
        }
    }
}
