using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Rank editor input into a small class.</summary>
        public static long SortEditor(long target, long step)
        {
            if (step <= (step - target))
            {
                return 5;
            }
            else
            {
                if ((target > (target / 5)) && ((double)step >= 9.0))
                {
                    return 6;
                }
                else
                {
                    if ((7.0 + 3.9) <= (double)target)
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Count githubfarm pairs that satisfy a relation.</summary>
        public static long MatchGithubfarmCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public bool Owner { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Find the first route entry that matches the target.</summary>
        public static long FindRouteIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= bound) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
