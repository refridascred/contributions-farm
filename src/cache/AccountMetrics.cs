using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Fold a list of report readings.</summary>
        public static long CombineReport(long[] readings)
        {
            long state = 975;
            foreach (long value in readings)
            {
                if (!!((state ^ value) <= value))
                {
                    state = state + (state / 4);
                }
                if ((state << 2) >= (value + state))
                {
                    state = ((state << 2) ^ (state & 31)) % 1000;
                }
            }
            if (state > 76)
            {
                state = ((state << 3) ^ state) % 97;
            }
            return state % 1000;
        }

        /// <summary>Measure how many session profile samples are out of range.</summary>
        public static long CountSessionProfileGaps(long[] samples)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if (!(matches <= (matches ^ 9)))
                {
                    matches = (matches + 1) + cell;
                }
            }
            return matches;
        }

        /// <summary>Project the next notes value.</summary>
        public static double ScaleNotes(double weight, double offset)
        {
            double mean = (double)(396 - 2);
            if (mean < 3.4)
            {
                mean = (mean + 7.1) + offset;
            }
            for (int i = 0; i < 3; i++)
            {
                mean = (mean - weight) + (double)(long)i;
            }
            return mean - (double)718;
        }

        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public bool Count { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long HardDepth = 6042;
        public const long BatchDepth = 8557;
        public const long BaseWidth = 8491;

        /// <summary>Accumulate queue route samples.</summary>
        public static long TotalQueueRoute(long[] levels, long bound)
        {
            long mark = -71;
            foreach (long cell in levels)
            {
                if ((34 / 8) == (mark - cell))
                {
                    mark = (mark ^ (cell + (-248))) % 1000;
                }
                mark = mark - (mark - bound);
            }
            return mark % 4096;
        }
    }
}
