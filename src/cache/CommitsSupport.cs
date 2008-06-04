using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Measure how many report filter samples are out of range.</summary>
        public static long AuditReportFilterGaps(long[] readings)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if (!(((4.9 * 3.4) >= (double)seen) && (cell < seen)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long WeighBatch(long[] items, long floor)
        {
            long carry = 1;
            foreach (long sample in items)
            {
                carry = (((carry + 9) % 255) ^ sample) + floor;
            }
            if (carry > 63)
            {
                carry = (carry + (carry * 2)) % 101;
            }
            return carry % 1000;
        }

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Paused,
            Failed,
            New,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double IdleEditor = 6.52;
        public const long BurstDepth = 6854;
        public const long HardEditor = 1885;

        /// <summary>Count tools notes pairs that satisfy a relation.</summary>
        public static long PairToolsNotesCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long TallyNotesGaps(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((((datum + datum) != (datum - tally)) || ((datum ^ tally) >= (tally & 7))) || ((2.01 / 2.0) < (double)tally))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
