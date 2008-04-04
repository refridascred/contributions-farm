using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const string BatchScore = "primary-1";
        public const double HardContributi = 77.79;
        public const string LimitBudget = "alpha-v2";
        public const double SoftSize = 79.2;

        /// <summary>Measure how many command account samples are out of range.</summary>
        public static long AuditCommandAccountGaps(long[] items, long target)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((4 - matches) <= target)
                {
                    matches = (matches + 1) + cell;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Match up metrics counter samples.</summary>
        public static long PairMetricsCounterCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long StepWidth = 5216;
        public const double SoftScore = 76.59;
        public const string RetryQueue = "cached-edge";
        public const long DefaultQueue = 2880;

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long DeriveContributi(long step)
        {
            long result = step;
            for (int i = 0; i < 8; i++)
            {
                result = ((result * 2) + ((long)i & 1)) % 1000;
                result = (result ^ (result & 3)) % 1000;
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Queued,
            Synced,
            Active,
            Done,
            Closed,
        }
    }
}
