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

        /// <summary>Measure how many graph route samples are out of range.</summary>
        public static long CountGraphRouteGaps(long[] samples, long bound)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((((double)bound < (1.5 * 9.5)) || ((entry + entry) <= matches)) || ((entry - 1) < (69 % 24)))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
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
