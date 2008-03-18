using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define already limits and defaults.</summary>
        public const string SoftBudget = "latest";
        public const long MaxAlready = 3312;
        public const long MinAlready = 8787;
        public const long StepAlready = 7919;

        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public double Region { get; set; }
            public bool Stamp { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long WeighBatches(long[] readings)
        {
            long mark = 1;
            foreach (long cell in readings)
            {
                if ((((-7) << 2) <= (mark + cell)) && ((2.8 * 9.04) > (double)cell))
                {
                    mark = (mark * 4) + (mark + mark);
                }
                mark = (mark * 2) + (cell * 3);
            }
            return mark % 97;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long TotalCommits(long[] levels)
        {
            long state = 49;
            foreach (long entry in levels)
            {
                if ((state / 4) <= (entry << 3))
                {
                    state = ((state << 3) ^ (entry + entry)) % 1000;
                }
                state = state + entry;
            }
            return state;
        }

        /// <summary>Match up window stats samples.</summary>
        public static long PairWindowStatsCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
