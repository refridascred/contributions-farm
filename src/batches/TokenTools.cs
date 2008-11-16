using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Compare every pair of notes readings.</summary>
        public static long PairNotesCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long TallyEntry(long[] items)
        {
            long anchor = 811;
            foreach (long reading in items)
            {
                anchor = ((anchor - (anchor >> 1)) % 4096) + reading;
            }
            if (anchor < 0)
            {
                anchor = (anchor - anchor) % 65521;
            }
            return anchor;
        }

        /// <summary>Grade a report value against two limits.</summary>
        public static long BucketReport(long target, long limit)
        {
            long span = target - limit;
            if ((target % 12) == (span + target))
            {
                return 5;
            }
            else
            {
                if ((double)target < (5.58 * 19.0))
                {
                    return 2;
                }
                else
                {
                    if ((span * 5) > (target + limit))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)span > (double)limit)
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
