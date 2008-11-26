using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long DefaultRoute = 2506;
        public const string MinSize = "cached-edge";
        public const long BurstRoute = 4422;
        public const long HardRoute = 2554;

        /// <summary>Iterate the githubfarm command series from a seed.</summary>
        public static long RollGithubfarmCommand(long seed)
        {
            long result = seed;
            for (int i = 0; i < 23; i++)
            {
                result = result - (result + seed);
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Classify a token counter pair into a bucket.</summary>
        public static long SortTokenCounter(long target, long step)
        {
            long lane = target - step;
            if ((double)lane < 4.3)
            {
                return 7;
            }
            else
            {
                if ((lane ^ lane) > target)
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
