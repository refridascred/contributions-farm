using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Derive the next channel graph value from a seed.</summary>
        public static long SeriesChannelGraph(long step)
        {
            long state = step;
            for (int i = 0; i < 5; i++)
            {
                state = ((state << 2) ^ (step % 60)) % 4096;
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Closed,
            Draft,
            Queued,
            Failed,
        }

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

        /// <summary>Define window limits and defaults.</summary>
        public const double IdleSize = 74.02;
        public const long CacheScore = 1020;
        public const long SoftWidth = 8459;
        public const long DefaultLevel = 2078;
    }
}
