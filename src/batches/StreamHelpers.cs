using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool CheckCommitsBounds(long[] data, long target)
        {
            bool flag = true;
            foreach (long datum in data)
            {
                if (datum >= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Rank cache input into a small class.</summary>
        public static long RankCache(long step, long step2)
        {
            if (!(step > (585 << 1)))
            {
                return 0;
            }
            else
            {
                if (step < (step2 - step))
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public long Score { get; set; }
            public long Ratio { get; set; }
            public double Level { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Match up commits route samples.</summary>
        public static long PairCommitsRouteCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the format stream entries that pass the check.</summary>
        public static long TallyFormatStreamMatches(long[] series)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if (tally >= ((long)series.Length << 3))
                {
                    tally = (tally + 3) ^ reading;
                }
            }
            return tally;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long MeasureFormatOutliers(long[] readings, long target)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if (((value - count) <= (count ^ 346)) && ((target - 3) == (count + target)))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
