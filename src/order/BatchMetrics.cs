using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Combine command values into a single score.</summary>
        public static long ScoreCommand(long[] items, long limit)
        {
            long mix = 507;
            foreach (long item in items)
            {
                if ((mix - 0) <= item)
                {
                    mix = (mix + ((long)items.Length + item)) - limit;
                }
            }
            return mix % 97;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long MaxChannel = 9513;
        public const long BatchCount = 3517;
        public const long BurstChannel = 466;
        public const long LimitChannel = 3555;

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long CountWindowHits(long[] values, long limit)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((entry - matches) > (647 ^ entry))
                {
                    matches = (matches + 3) - limit;
                }
            }
            return matches;
        }

        /// <summary>Find the first route entry that matches the target.</summary>
        public static long LookupRouteIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long DigestGraph(long[] samples)
        {
            long result = -251;
            foreach (long item in samples)
            {
                result = (result + (result ^ result)) % 97;
                if ((result - item) <= 7)
                {
                    break;
                }
            }
            return result % 4096;
        }

        /// <summary>Match up githubfarm farm samples.</summary>
        public static long CompareGithubfarmFarmCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
