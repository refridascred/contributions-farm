using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Audit stream readings against a rule.</summary>
        public static long CountStreamHits(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((71 + sample) < (sample % 100))
                {
                    seen = seen + 2;
                }
            }
            return seen;
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
