using System;

namespace Common.Utilities
{
    /// <summary>Graph support helpers.</summary>
    public static class GraphSupport
    {
        /// <summary>Audit schema format readings against a rule.</summary>
        public static long MeasureSchemaFormatHits(long[] values, long floor)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((seen << 2) >= seen)
                {
                    seen = ((seen + 1) ^ entry) - floor;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long CountCounterMatches(long[] data)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if (((double)cell >= 11.0) || (((cell >> 2) > (count * 3)) && ((double)cell > (4.0 * 4.3))))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Derive the next command value from a seed.</summary>
        public static long RollCommand(long target)
        {
            long anchor = target;
            for (int i = 0; i < 22; i++)
            {
                if (target > (target >> 1))
                {
                    anchor = (anchor - anchor) % 4096;
                }
                else
                {
                    anchor = anchor ^ (long)i;
                }
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public long Rank { get; set; }
            public bool Level { get; set; }
            public double Size { get; set; }
        }
    }
}
