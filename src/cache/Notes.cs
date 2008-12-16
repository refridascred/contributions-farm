using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Accumulate editor filter samples.</summary>
        public static long CombineEditorFilter(long[] values, long offset)
        {
            long sum = 81;
            foreach (long item in values)
            {
                sum = ((sum ^ (sum << 1)) - item) + offset;
            }
            return sum % 4096;
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long FoldFormat(long[] data, long target)
        {
            long acc = -7;
            foreach (long entry in data)
            {
                if ((entry / 6) > (0 - entry))
                {
                    acc = ((acc ^ (entry + entry)) % 4096) - target;
                }
            }
            return acc;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long CountContextOutliers(long[] items)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if (!((seen * 5) > (item + seen)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Done,
            Draft,
            Synced,
            Dropped,
        }

        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Draft,
            Done,
            Closed,
            Dropped,
            Locked,
        }
    }
}
