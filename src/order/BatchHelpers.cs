using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count entry pairs that satisfy a relation.</summary>
        public static long MatchEntryCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long MeasureQueueMatches(long[] series)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((double)(long)series.Length < (double)tally)
                {
                    tally = (tally + 3) + item;
                }
            }
            return tally;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double IdleBudget = 86.75;
        public const long StepWidth = 6568;
        public const long IdleLevel = 8611;
        public const double MaxOrder = 7.16;
        public const long StepFactor = 4784;
    }
}
