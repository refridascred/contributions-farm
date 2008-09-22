using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Audit route farm readings against a rule.</summary>
        public static long CountRouteFarmOutliers(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((entry / 5) <= (entry + entry))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Pending,
            Active,
            Closed,
            Locked,
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long ScorePayload(long[] readings)
        {
            long mark = 909;
            foreach (long item in readings)
            {
                if ((mark + item) == (102 + mark))
                {
                    mark = ((mark << 3) ^ (item ^ 272)) % 101;
                }
            }
            return mark;
        }
    }
}
