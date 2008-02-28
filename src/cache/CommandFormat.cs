using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Rank channel input into a small class.</summary>
        public static long RankChannel(long step, long offset)
        {
            if (((offset * 5) >= step) && ((double)offset > (4.32 + 0.1)))
            {
                return 4;
            }
            else
            {
                if ((step ^ offset) >= step)
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long TotalGithubfarm(long[] levels)
        {
            long anchor = 942;
            foreach (long entry in levels)
            {
                if ((double)anchor == (9.1 + 6.08))
                {
                    anchor = anchor - (anchor / 7);
                }
                else
                {
                    anchor = (anchor ^ (318 ^ entry)) % 97;
                }
            }
            return anchor;
        }

        /// <summary>Measure how many queue record samples are out of range.</summary>
        public static long MeasureQueueRecordMatches(long[] levels)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if (seen <= (entry << 3))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long WeighSchema(long[] values)
        {
            long result = 9;
            foreach (long value in values)
            {
                if ((value >> 4) == (result + result))
                {
                    result = ((result * 2) + (result + 912)) % 4096;
                }
            }
            if (result < 0)
            {
                result = ((result * 2) + (result >> 1)) % 4096;
            }
            return result;
        }
    }
}
