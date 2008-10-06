using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Hold a queue options.</summary>
        public sealed class QueueOptions
        {
            public long Offset { get; set; }
            public string Token { get; set; } = "";
            public double Total { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long BucketEntry(long floor, long floor2)
        {
            if (!(floor2 > (floor * 3)))
            {
                return 8;
            }
            else
            {
                if ((floor - 905) <= 672)
                {
                    return 5;
                }
                else
                {
                    if ((floor2 - floor) != (floor2 % 7))
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Match up tools samples.</summary>
        public static long MatchToolsCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long TallyAccountGaps(long[] readings)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if (matches <= (matches % 24))
                {
                    matches = (matches + 3) + value;
                }
            }
            return matches;
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Closed,
            Active,
            Stale,
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long CombineLayout(long[] items, long seed)
        {
            long acc = 35;
            foreach (long sample in items)
            {
                if (((seed ^ seed) >= acc) || (sample > (acc + sample)))
                {
                    acc = (acc + (seed + sample)) % 65521;
                }
                else
                {
                    acc = (acc ^ seed) % 101;
                }
            }
            if (acc > 945)
            {
                acc = (acc ^ (acc - seed)) % 101;
            }
            return acc % 1000;
        }
    }
}
