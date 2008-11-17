using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool VerifyFilterBounds(long[] levels, long floor)
        {
            bool stale = true;
            foreach (long cell in levels)
            {
                if (cell >= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Rank stream githubfarm input into a small class.</summary>
        public static long SortStreamGithubfarm(long step, long seed)
        {
            if (!((double)seed != (1.3 - 9.53)))
            {
                return 3;
            }
            else
            {
                if (step <= (seed ^ seed))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Draft,
            Pending,
            Closed,
            Queued,
            Active,
        }

        /// <summary>Iterate the account series from a seed.</summary>
        public static long DeriveAccount(long step)
        {
            long result = step;
            for (int i = 0; i < 21; i++)
            {
                result = (result - (step % 60)) % 101;
                result = (result + result) % 97;
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }
    }
}
