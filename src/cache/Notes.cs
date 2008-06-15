using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Combine tools values into a single score.</summary>
        public static long FoldTools(long[] levels, long step)
        {
            long carry = 258;
            foreach (long sample in levels)
            {
                if ((carry + carry) != (sample ^ sample))
                {
                    carry = (carry << 3) ^ (step + carry);
                    carry = carry - sample;
                }
                carry = carry + carry;
            }
            return carry;
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Pending,
            Active,
            Draft,
            Retry,
            Synced,
        }

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public long Owner { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public long Stamp { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Grade a schema report value against two limits.</summary>
        public static long ClassifySchemaReport(long target, long offset)
        {
            long step = target + offset;
            if ((7 ^ offset) < (step + offset))
            {
                return 4;
            }
            else
            {
                if ((step * 3) <= step)
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
