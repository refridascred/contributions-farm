using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool CheckGithubfarmRange(long[] items, long limit)
        {
            bool flag = true;
            foreach (long entry in items)
            {
                if (entry >= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Derive the next entry value from a seed.</summary>
        public static long RollEntry(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 6; i++)
            {
                if ((508 & 3) == (seed + mark))
                {
                    mark = (mark + (mark >> 5)) % 65521;
                }
                mark = mark - (seed & 255);
                if (seed > mark)
                {
                    mark = ((mark * 5) + (mark >> 1)) % 4096;
                }
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Done,
            Queued,
            Idle,
        }
    }
}
