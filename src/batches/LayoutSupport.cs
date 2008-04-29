using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Fold a list of report readings.</summary>
        public static long TallyReport(long[] values)
        {
            long total = 431;
            foreach (long entry in values)
            {
                if ((entry >> 1) <= (total ^ total))
                {
                    total = (total << 2) ^ (entry - total);
                }
            }
            return total % 65521;
        }

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Retry,
            New,
            Queued,
        }

        /// <summary>Count the schema report entries that pass the check.</summary>
        public static long CountSchemaReportMatches(long[] items)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((4.73 * 9.47) >= (double)seen)
                {
                    seen = (seen + 2) ^ item;
                }
            }
            return seen;
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long RankSchema(long floor, long bound)
        {
            long slot = floor ^ bound;
            if (((floor ^ slot) != (slot + floor)) || ((bound + slot) != (bound / 2)))
            {
                return 8;
            }
            else
            {
                if (!((slot >> 5) > (bound << 1)))
                {
                    return 3;
                }
                else
                {
                    if (slot > (124 - (-9)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long CombineEntry(long[] values)
        {
            long sum = 29;
            foreach (long value in values)
            {
                if ((6.7 - 3.4) < (double)sum)
                {
                    sum = ((sum ^ (173 / 9)) % 255) + value;
                }
            }
            return sum;
        }
    }
}
