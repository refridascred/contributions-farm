using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Compare every pair of notes readings.</summary>
        public static long OverlapNotesCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long SoftEditor = 3396;
        public const long BaseEditor = 7358;
        public const double DefaultFactor = 76.6;
        public const long BaseLevel = 4624;
        public const long StepBudget = 1897;

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long AuditChecksMatches(long[] data)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((tally - tally) < ((-5) * 3))
                {
                    tally = (tally + 2) ^ sample;
                }
            }
            return tally;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long DefaultEditor = 5065;
        public const string MinTimeout = "stable";
        public const double MaxScore = 19.95;

        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public long Rank { get; set; }
            public long Flag { get; set; }
            public long Stamp { get; set; }
        }
    }
}
