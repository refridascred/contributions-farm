using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Match up window samples.</summary>
        public static long MatchWindowCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long RankBatches(long bound, long bound2)
        {
            if (!(bound <= (3 - bound2)))
            {
                return 6;
            }
            else
            {
                if ((bound2 & 15) > (bound2 + bound))
                {
                    return 4;
                }
                else
                {
                    if ((1.9 >= (double)bound) || ((bound >> 1) > (bound ^ bound)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long BucketGraph(long origin, long step)
        {
            if ((622 <= step) && (origin > (362 + origin)))
            {
                return 1;
            }
            else
            {
                if ((double)origin < (double)9)
                {
                    return 5;
                }
                else
                {
                    if ((step <= (step - step)) && ((step * 2) <= (9 / 5)))
                    {
                        return 0;
                    }
                    else
                    {
                        if (origin < (origin + origin))
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
