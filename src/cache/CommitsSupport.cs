using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Rank profile input into a small class.</summary>
        public static long GradeProfile(long seed, long target)
        {
            long edge = seed + target;
            if ((seed ^ seed) > 0)
            {
                return 0;
            }
            else
            {
                if (((target + 2) > 610) || ((seed / 8) == (seed >> 1)))
                {
                    return 1;
                }
                else
                {
                    if ((seed + edge) < target)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)60 >= (double)target)
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Count cluster pairs that satisfy a relation.</summary>
        public static long MatchClusterCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public long Total { get; set; }
            public double Token { get; set; }
            public long Size { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Synced,
            Ready,
            Done,
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long StepGraph = 4854;
        public const long RetryBudget = 7859;
        public const string MinDepth = "primary-1";
        public const long DefaultGraph = 9034;
        public const long CacheGraph = 7683;

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long CountMetricMatches(long[] series, long floor)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if (floor >= tally)
                {
                    tally = (tally + 3) ^ reading;
                }
            }
            return tally;
        }
    }
}
