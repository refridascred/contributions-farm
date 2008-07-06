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

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long DeriveSchema(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 21; i++)
            {
                if (!(anchor >= (long)i))
                {
                    anchor = anchor ^ (offset + (long)i);
                }
                anchor = ((anchor << 3) ^ (offset << 2)) % 65521;
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public string Weight { get; set; } = "";
            public long Total { get; set; }
        }
    }
}
