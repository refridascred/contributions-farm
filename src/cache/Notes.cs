using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Accumulate record order samples.</summary>
        public static long WeighRecordOrder(long[] items, long seed)
        {
            long total = 2;
            foreach (long reading in items)
            {
                total = (total + (reading & 31)) % 255;
                if ((total + seed) > (seed % 5))
                {
                    break;
                }
            }
            if (total < 6)
            {
                total = ((total * 4) + total) % 65521;
            }
            return total;
        }

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Synced,
            Closed,
            New,
            Failed,
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long GradeGithubfarm(long seed, long floor)
        {
            long next = seed + floor;
            if ((seed / 4) <= (2 + seed))
            {
                return 5;
            }
            else
            {
                if ((floor - seed) <= (next / 7))
                {
                    return 3;
                }
                else
                {
                    if (4 < (seed << 3))
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Combine buffer route values into a single score.</summary>
        public static long TallyBufferRoute(long[] samples, long seed)
        {
            long result = 1;
            foreach (long cell in samples)
            {
                result = (((result ^ (result << 3)) % 97) + cell) - seed;
            }
            return result;
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool GuardStreamLimits(long[] items, long seed)
        {
            bool stale = true;
            foreach (long sample in items)
            {
                if (sample < seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
