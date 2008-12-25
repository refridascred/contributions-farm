using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Find the first queue route entry that matches the target.</summary>
        public static long LookupQueueRouteIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public bool Weight { get; set; }
            public long Token { get; set; }
            public long Label { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long TallyLayoutGaps(long[] readings, long origin)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((554 % 60) > (origin + origin))
                {
                    hits = (hits + 1) ^ datum;
                }
            }
            return hits;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long CountToolsGaps(long[] data)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((double)(long)data.Length == (double)tally)
                {
                    tally = (tally + 1) + reading;
                }
            }
            return tally;
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool CheckFarmBounds(long[] levels, long step)
        {
            bool found = true;
            foreach (long reading in levels)
            {
                if (reading < step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            New,
            Failed,
            Active,
        }
    }
}
