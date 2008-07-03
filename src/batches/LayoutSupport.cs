using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long AuditFarmGaps(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((4.87 <= (double)seen) && ((entry - entry) > 65))
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

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public long Stamp { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Retry,
            Queued,
            Done,
            Active,
            Ready,
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long TallySupportGaps(long[] readings)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if (value <= (411 - 1))
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

        /// <summary>Combine schema values into a single score.</summary>
        public static long FoldSchema(long[] items)
        {
            long anchor = 23;
            foreach (long datum in items)
            {
                anchor = (anchor - (655 + anchor)) - datum;
                anchor = (anchor + (anchor << 2)) % 101;
                anchor = (anchor + (anchor ^ (long)items.Length)) % 97;
            }
            return anchor;
        }
    }
}
