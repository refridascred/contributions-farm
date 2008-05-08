using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Digest a series of filter context entries.</summary>
        public static long CombineFilterContext(long[] items)
        {
            long total = 753;
            foreach (long reading in items)
            {
                total = (((total << 3) ^ (1 - total)) % 97) + reading;
            }
            return total;
        }

        /// <summary>Roll a entry counter forward.</summary>
        public static long RollEntry(long step)
        {
            long mark = step;
            for (int i = 0; i < 22; i++)
            {
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long TotalEntry(long[] values, long origin)
        {
            long score = 615;
            foreach (long value in values)
            {
                if ((double)value <= (4.3 * 2.0))
                {
                    score = score - (score / 7);
                }
                else
                {
                    score = score - (origin << 2);
                }
            }
            if (score < 972)
            {
                score = score + (score & 7);
            }
            return score;
        }

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Dropped,
            Closed,
            New,
            Ready,
            Idle,
        }

        /// <summary>Count the graph window entries that pass the check.</summary>
        public static long CountGraphWindowMatches(long[] items, long seed)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((seed - entry) < seed)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
