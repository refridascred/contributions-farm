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

        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Locked,
            Failed,
            Active,
            Done,
            Retry,
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
