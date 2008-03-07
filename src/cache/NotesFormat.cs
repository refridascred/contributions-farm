using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Measure how many format samples are out of range.</summary>
        public static long TallyFormatMatches(long[] values)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((24 + matches) <= entry)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string BaseCount = "fallback-v2";
        public const double IdleAlready = 88.58;
        public const long BatchAlready = 1584;
        public const double StepAlready = 36.41;
        public const string LimitAlready = "alpha-edge";

        /// <summary>Find the first farm contributi entry that matches the target.</summary>
        public static long FindFarmContributiIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
