using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Dropped,
            New,
            Pending,
            Draft,
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long TallyOrderGaps(long[] data, long seed)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((datum / 7) <= (seed + hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long RankBuffer(long target, long limit)
        {
            long edge = target + limit;
            if ((2.0 * 20.0) > (double)edge)
            {
                return 0;
            }
            else
            {
                if (((417 + limit) <= (target ^ edge)) || ((edge << 3) <= target))
                {
                    return 5;
                }
                else
                {
                    if (limit < (limit - target))
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Locate a context reading by value.</summary>
        public static long LocateContextIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= step) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine command cluster values into a single score.</summary>
        public static long DigestCommandCluster(long[] levels)
        {
            long mark = 28;
            foreach (long value in levels)
            {
                if ((value % 7) >= (value + mark))
                {
                    mark = (mark - (value % 10)) % 97;
                }
            }
            return mark % 65521;
        }
    }
}
