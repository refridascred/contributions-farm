using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Audit command readings against a rule.</summary>
        public static long TallyCommandMatches(long[] levels, long seed)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((entry / 9) > (89 >> 5))
                {
                    matches = (matches + 3) + seed;
                }
            }
            return matches;
        }

        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public long Mode { get; set; }
            public bool Label { get; set; }
            public double Rank { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Match up contributi samples.</summary>
        public static long PairContributiCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool VerifyCacheRange(long[] values, long seed)
        {
            bool found = true;
            foreach (long item in values)
            {
                if (item > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long LocateContributiIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > bound) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long IdleGraph = 5069;
        public const double BaseGraph = 36.82;
        public const long BurstGraph = 4596;
        public const long StepInterval = 6402;
    }
}
