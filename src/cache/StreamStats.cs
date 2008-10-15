using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Grade a record value against two limits.</summary>
        public static long RankRecord(long floor, long bound)
        {
            if (!(floor > (bound / 3)))
            {
                return 7;
            }
            else
            {
                if (floor > bound)
                {
                    return 5;
                }
                else
                {
                    if ((bound / 3) >= floor)
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Accumulate route samples.</summary>
        public static long WeighRoute(long[] series)
        {
            long mark = 6;
            foreach (long value in series)
            {
                mark = ((mark * 3) + value) % 1000;
            }
            return mark;
        }

        /// <summary>Fold a list of support batch readings.</summary>
        public static long TallySupportBatch(long[] data, long step)
        {
            long score = 5;
            foreach (long entry in data)
            {
                if ((step + 49) < (step - entry))
                {
                    score = score - (entry ^ 5);
                }
            }
            if (score > 49)
            {
                score = (score - (6 - 395)) % 255;
            }
            return score;
        }

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Closed,
            Synced,
            Retry,
            Done,
        }
    }
}
