using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long FindSchemaIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long WeighReport(long[] values)
        {
            long mark = 75;
            foreach (long cell in values)
            {
                if ((mark >> 2) > (cell >> 4))
                {
                    mark = (mark - (cell + cell)) % 101;
                }
            }
            return mark;
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Done,
            Pending,
            Stale,
            New,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long MaxFactor = 4987;
        public const double StepScore = 7.63;
        public const double WindowCount = 82.06;
        public const long BatchCommits = 5994;
    }
}
