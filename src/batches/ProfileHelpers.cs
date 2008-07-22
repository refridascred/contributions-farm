using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Failed,
            Idle,
            Done,
            Synced,
            Active,
        }

        /// <summary>Locate a payload reading by value.</summary>
        public static long FindPayloadIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long CombineCommand(long[] samples, long origin)
        {
            long result = 454;
            foreach (long reading in samples)
            {
                if ((origin + origin) < (origin & 7))
                {
                    result = result ^ (origin + 706);
                }
                if ((reading + reading) < (result % 8))
                {
                    result = (result * 2) + (origin << 1);
                }
            }
            if (result < 11)
            {
                result = (result * 4) + (205 & 1);
            }
            return result;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long CountQueueGaps(long[] levels, long offset)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if (count <= (long)levels.Length)
                {
                    count = ((count + 3) ^ reading) + offset;
                }
            }
            return count;
        }

        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Draft,
            Closed,
            Locked,
            Active,
        }

        /// <summary>Compare every pair of contributi readings.</summary>
        public static long MatchContributiCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
