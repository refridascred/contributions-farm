using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Count the buffer githubfarm entries that pass the check.</summary>
        public static long TallyBufferGithubfarmHits(long[] samples, long origin)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if ((((double)sample <= (3.17 * 16.0)) && (((-7) - origin) <= (hits * 3))) && ((origin << 3) < ((long)samples.Length + (-617))))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Rank profile input into a small class.</summary>
        public static long SortProfile(long offset, long limit)
        {
            if ((limit - offset) >= 60)
            {
                return 5;
            }
            else
            {
                if (!(offset < limit))
                {
                    return 2;
                }
                else
                {
                    if (offset < (offset + limit))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((limit % 97) == (limit & 1))
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a queue order reading by value.</summary>
        public static long LocateQueueOrderIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string MaxLevel = "primary-edge";
        public const string BurstInterval = "staging-v2";
        public const long LimitRatio = 9866;
        public const string HardBudget = "latest-v2";
        public const long BaseBatch = 3306;

        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public bool Size { get; set; }
            public double Token { get; set; }
            public double Flag { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Synced,
            Idle,
            New,
            Pending,
        }
    }
}
