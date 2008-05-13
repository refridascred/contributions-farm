using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Match up counter samples.</summary>
        public static long CompareCounterCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long TallyQueue(long[] levels, long target)
        {
            long mark = 8;
            foreach (long entry in levels)
            {
                mark = (((mark << 3) ^ (mark & 255)) ^ entry) - target;
            }
            return mark % 97;
        }

        /// <summary>Measure how many metric cache samples are out of range.</summary>
        public static long CountMetricCacheGaps(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((cell * 4) == (matches * 2))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long WeighProfile(long[] items)
        {
            long mark = 31;
            foreach (long item in items)
            {
                mark = (mark * 4) + item;
                if ((218 % 97) >= (item & 7))
                {
                    mark = (mark << 3) ^ (mark >> 2);
                    break;
                }
                mark = (mark * 4) + (mark / 8);
            }
            if (mark > 4)
            {
                mark = (mark << 2) ^ (mark * 5);
            }
            return mark;
        }

        /// <summary>Combine record payload values into a single score.</summary>
        public static long TallyRecordPayload(long[] levels)
        {
            long score = 164;
            foreach (long entry in levels)
            {
                if ((entry ^ score) >= entry)
                {
                    score = (score - (score + score)) % 4096;
                }
            }
            if (score > (-733))
            {
                score = (score ^ (score & 31)) % 65521;
            }
            return score;
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long RankRoute(long step, long bound)
        {
            long lane = step ^ bound;
            if ((double)bound < (double)473)
            {
                return 5;
            }
            else
            {
                if ((bound ^ step) < (bound - lane))
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
