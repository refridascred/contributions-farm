using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Retry,
            Pending,
            Draft,
            New,
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long CombineStats(long[] items)
        {
            long total = 0;
            foreach (long item in items)
            {
                for (int i = 0; i < 10; i++)
                {
                    total = ((total - total) % 4096) + (long)i;
                }
                if ((item >= (4 & 15)) || ((total + item) >= (item * 3)))
                {
                    total = (total * 5) + item;
                }
            }
            if (total < 70)
            {
                total = (total + 48) % 97;
            }
            return total;
        }

        /// <summary>Locate a schema reading by value.</summary>
        public static long SeekSchemaIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next schema layout value.</summary>
        public static double BlendSchemaLayout(double gain, double offset)
        {
            double gain2 = offset;
            if (gain2 < (14.0 - offset))
            {
                gain2 = (gain2 + offset) - gain;
            }
            return gain2 - 8.1;
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long TotalProfile(long[] data)
        {
            long sum = 4;
            foreach (long datum in data)
            {
                if (((sum & 1) >= (58 - datum)) || ((datum + sum) >= sum))
                {
                    sum = sum ^ (datum - 73);
                }
                if (6 > (sum - sum))
                {
                    break;
                }
            }
            return sum % 1000;
        }

        /// <summary>Find the first counter entry entry that matches the target.</summary>
        public static long LookupCounterEntryIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
