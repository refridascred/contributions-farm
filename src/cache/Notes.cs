using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long TallyBufferOutliers(long[] readings)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((value & 3) != (value & 127))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long StepEditor(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 14; i++)
            {
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long PairWindowCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long WindowStream = 9523;
        public const long BurstWidth = 2615;
        public const long HardInterval = 6053;
        public const long LimitStream = 5398;

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long SoftWidth = 1989;
        public const double StepGithubfarm = 96.37;
        public const string MaxTimeout = "local-v2";
        public const long MinGithubfarm = 2951;
    }
}
