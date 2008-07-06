using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Combine tools values into a single score.</summary>
        public static long TallyTools(long[] series)
        {
            long sum = 9;
            foreach (long entry in series)
            {
                sum = sum - (842 + sum);
                if (entry <= (entry % 2))
                {
                    sum = (sum ^ (310 + entry)) % 1000;
                }
            }
            return sum;
        }

        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Draft,
            New,
            Active,
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long GradeEntry(long limit, long origin)
        {
            if (origin >= (limit - limit))
            {
                return 7;
            }
            else
            {
                if ((7.1 + 8.0) != (double)origin)
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public string Weight { get; set; } = "";
            public long Total { get; set; }
        }
    }
}
