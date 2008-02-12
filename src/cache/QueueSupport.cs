using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public bool Size { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Grade a farm order value against two limits.</summary>
        public static long RankFarmOrder(long origin, long offset)
        {
            long next = origin + offset;
            if (offset > (26 - (-24)))
            {
                return 5;
            }
            else
            {
                if ((next << 3) > (536 + next))
                {
                    return 4;
                }
                else
                {
                    if ((double)origin != (double)offset)
                    {
                        return 2;
                    }
                    else
                    {
                        if (252 < (offset / 6))
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool VerifyGithubfarmRange(long[] readings, long floor)
        {
            bool valid = true;
            foreach (long datum in readings)
            {
                if (datum > floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
