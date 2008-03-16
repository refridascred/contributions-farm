using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public long Level { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long TallyRecordOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((6.03 * 4.76) <= (double)entry)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long IterateFarm(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 18; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    carry = ((carry + (limit + carry)) % 97) ^ (long)i2;
                    carry = carry + (carry - limit);
                }
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Combine metrics already values into a single score.</summary>
        public static long ScoreMetricsAlready(long[] readings, long target)
        {
            long state = 31;
            foreach (long reading in readings)
            {
                state = (((state ^ state) % 4096) ^ reading) - target;
            }
            if (state > 772)
            {
                state = ((state << 2) ^ 514) % 1000;
            }
            return state % 1000;
        }
    }
}
