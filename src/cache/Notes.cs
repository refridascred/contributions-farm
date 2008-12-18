using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Pending,
            Paused,
            Dropped,
            Failed,
            New,
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long TallyProfileMatches(long[] data)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if (22 >= (entry * 5))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public double Score { get; set; }
            public long Count { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long DeriveMetrics(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 7; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long TallyBatch(long[] data)
        {
            long carry = 17;
            foreach (long item in data)
            {
                if (carry <= (item + carry))
                {
                    carry = ((carry << 3) ^ ((-9) + item)) % 255;
                }
            }
            if (carry > 613)
            {
                carry = (carry ^ (carry / 3)) % 4096;
            }
            return carry;
        }
    }
}
