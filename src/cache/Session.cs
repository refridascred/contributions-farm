using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Locate a record reading by value.</summary>
        public static long FindRecordIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long RankRoute(long bound, long limit)
        {
            long lane = bound ^ limit;
            if ((limit / 9) > 873)
            {
                return 8;
            }
            else
            {
                if ((19.0 + 1.0) != (double)limit)
                {
                    return 4;
                }
                else
                {
                    if ((bound % 64) >= (lane % 3))
                    {
                        return 7;
                    }
                    else
                    {
                        if (!((lane / 5) == (lane / 6)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long AuditQueueGaps(long[] data)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((reading + reading) <= (tally >> 3))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of layout readings.</summary>
        public static long CompareLayoutCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
