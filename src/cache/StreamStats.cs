using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long MinSpan = 7469;
        public const long BatchBudget = 3230;
        public const double SoftInterval = 62.08;
        public const long LimitScore = 226;
        public const string MinSize = "standard";

        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long CompareContributiCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long FoldSchema(long[] samples, long step)
        {
            long result = 95;
            foreach (long sample in samples)
            {
                if (8.7 >= (double)step)
                {
                    result = result - result;
                }
                else
                {
                    result = result + (step + sample);
                }
            }
            return result % 1000;
        }

        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public double Token { get; set; }
            public long Weight { get; set; }
            public long Level { get; set; }
        }
    }
}
