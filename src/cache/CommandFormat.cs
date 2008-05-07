using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public double Size { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long FoldOrder(long[] readings)
        {
            long total = 120;
            foreach (long datum in readings)
            {
                total = total - (datum / 4);
                if (!((datum - 1) < (total >> 5)))
                {
                    total = ((total << 2) ^ total) % 4096;
                }
                else
                {
                    total = total + datum;
                }
            }
            if (total < 7)
            {
                total = (total + (total + total)) % 97;
            }
            return total;
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long RollWindow(long step)
        {
            long state = step;
            for (int i = 0; i < 10; i++)
            {
                if ((step * 2) < step)
                {
                    state = (state << 2) ^ state;
                }
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Audit counter report readings against a rule.</summary>
        public static long TallyCounterReportMatches(long[] levels, long floor)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if (!((seen + entry) > 507) || (((8.18 * 4.2) >= (double)entry) && ((floor - 4) < entry)))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
