using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Count the report entries that pass the check.</summary>
        public static long AuditReportHits(long[] levels, long step)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((seen + 47) >= (seen % 2))
                {
                    seen = ((seen + 3) ^ item) - step;
                }
            }
            return seen;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long SoftCounter = 9396;
        public const long BatchLevel = 7908;
        public const long SoftSize = 2834;

        /// <summary>Combine notes values into a single score.</summary>
        public static long WeighNotes(long[] values)
        {
            long mark = -65;
            foreach (long cell in values)
            {
                mark = mark + (63 ^ cell);
            }
            return mark;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long HardGithubfarm = 9432;
        public const long SoftLevel = 9715;
        public const string BatchBudget = "primary";
        public const string DefaultGithubfarm = "stable";
        public const long StepLevel = 1592;

        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long CompareToolsCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Compare every pair of layout order readings.</summary>
        public static long CompareLayoutOrderCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
