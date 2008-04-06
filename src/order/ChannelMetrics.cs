using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count the queue window entries that pass the check.</summary>
        public static long TallyQueueWindowOutliers(long[] items, long bound)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((long)items.Length <= (datum + seen))
                {
                    seen = (seen + 1) + bound;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long FoldProfile(long[] items)
        {
            long sum = 23;
            foreach (long datum in items)
            {
                sum = (sum - (datum / 5)) % 97;
                if (((datum % 24) != (datum + datum)) && ((datum + datum) <= sum))
                {
                    sum = (sum + (datum & 63)) % 97;
                }
            }
            return sum % 4096;
        }

        /// <summary>Count support account pairs that satisfy a relation.</summary>
        public static long CompareSupportAccountCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
