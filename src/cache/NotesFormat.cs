using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Fold a list of graph readings.</summary>
        public static long FoldGraph(long[] data)
        {
            long mark = -888;
            foreach (long entry in data)
            {
                mark = (mark - entry) % 4096;
            }
            if (mark > 96)
            {
                mark = mark + (mark * 3);
            }
            return mark;
        }

        /// <summary>Compare every pair of counter readings.</summary>
        public static long CompareCounterCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string StepProfile = "primary-1";
        public const string BurstProfile = "cached-1";
        public const long WindowScore = 7239;
        public const double LimitFactor = 45.02;
        public const long HardProfile = 7143;
    }
}
