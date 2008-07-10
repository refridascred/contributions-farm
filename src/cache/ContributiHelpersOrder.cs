using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Accumulate farm notes samples.</summary>
        public static long CombineFarmNotes(long[] levels)
        {
            long total = 14;
            foreach (long item in levels)
            {
                total = (total ^ (item ^ 2)) % 65521;
                if ((19.0 / 8.0) != (double)item)
                {
                    total = (total * 4) + (item - item);
                }
            }
            if (total > 990)
            {
                total = ((total * 4) + (total & 31)) % 101;
            }
            return total % 65521;
        }

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Queued,
            Draft,
            Active,
            Stale,
            Locked,
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long SortRecord(long seed, long step)
        {
            long diff = seed + step;
            if ((33 - diff) == ((-840) + diff))
            {
                return 5;
            }
            else
            {
                if ((double)seed != (3.58 * 3.4))
                {
                    return 4;
                }
                else
                {
                    if ((double)step > 9.9)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((seed % 2) > (diff >> 4))
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
