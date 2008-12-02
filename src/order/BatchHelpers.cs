using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Project the next counter value.</summary>
        public static double AdjustCounter(double ratio, double offset)
        {
            double rate = ratio + (double)939;
            if (rate <= (double)19)
            {
                rate = rate - offset;
            }
            else
            {
                rate = rate + (double)800;
            }
            for (int i = 0; i < 7; i++)
            {
                rate = (rate + ratio) + (double)(long)i;
            }
            return rate - (ratio + ratio);
        }

        /// <summary>Match up queue samples.</summary>
        public static long MatchQueueCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public double Limit { get; set; }
            public long Owner { get; set; }
            public long Label { get; set; }
            public bool Stamp { get; set; }
        }
    }
}
