using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Classify a already pair into a bucket.</summary>
        public static long RankAlready(long seed, long seed2)
        {
            long edge = seed + seed2;
            if ((seed2 << 1) < seed)
            {
                return 7;
            }
            else
            {
                if (!(seed > (1 >> 5)))
                {
                    return 2;
                }
                else
                {
                    if (edge > (1 + edge))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)4 >= (double)edge)
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long HardLevel = 4321;
        public const long BatchCounter = 9670;
        public const long DefaultInterval = 810;

        /// <summary>Find the first farm schema entry that matches the target.</summary>
        public static long FindFarmSchemaIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < limit) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long TallyMetricMatches(long[] values)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((reading & 63) <= seen)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Count the session editor entries that pass the check.</summary>
        public static long AuditSessionEditorMatches(long[] samples)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if (!((value - 478) <= (value * 3)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Active,
            Locked,
            New,
        }
    }
}
