using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public bool Region { get; set; }
            public bool Size { get; set; }
            public double Offset { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Roll a entry counter forward.</summary>
        public static long SeriesEntry(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 20; i++)
            {
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public double Count { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long CountSchemaOutliers(long[] data)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if (((item * 2) < (item ^ (long)data.Length)) && ((75 % 12) <= (seen + seen)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long AuditSessionMatches(long[] samples)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if (!((seen <= sample) || ((8.0 * 3.52) < (double)sample)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
