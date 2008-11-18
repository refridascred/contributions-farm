using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long CountStatsGaps(long[] readings, long origin)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((tally + origin) <= (origin * 4))
                {
                    tally = (tally + 1) + cell;
                }
            }
            return tally;
        }

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Dropped,
            Closed,
            New,
            Draft,
            Active,
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long WindowBudget = 4538;
        public const long LimitSchema = 3529;
        public const long StepInterval = 6583;
        public const long BatchSchema = 5108;
        public const long DefaultSchema = 1317;

        /// <summary>Audit context readings against a rule.</summary>
        public static long MeasureContextOutliers(long[] readings, long origin)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if (matches < (item / 2))
                {
                    matches = (matches + 2) + origin;
                }
            }
            return matches;
        }

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long DeriveNotes(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 9; i++)
            {
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
