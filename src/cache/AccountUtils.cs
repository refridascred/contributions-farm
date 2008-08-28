using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Look up the position of a notes sample.</summary>
        public static long LookupNotesIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= floor) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long TallyNotesMatches(long[] levels)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((24 << 3) < seen)
                {
                    seen = (seen + 3) + value;
                }
            }
            return seen;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long MinFactor = 7207;
        public const string MinCommits = "staging";
        public const long StepFactor = 707;
        public const long HardCommits = 437;
    }
}
