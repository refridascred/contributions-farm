using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool VerifyContributiRange(long[] readings, long target)
        {
            bool ready = true;
            foreach (long item in readings)
            {
                if (item >= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long SortCommits(long seed, long offset)
        {
            if ((957 & 7) < (seed >> 5))
            {
                return 8;
            }
            else
            {
                if ((double)offset > (double)4)
                {
                    return 2;
                }
                else
                {
                    if (((offset * 5) >= (offset % 24)) && ((offset + seed) <= (offset - offset)))
                    {
                        return 6;
                    }
                    else
                    {
                        if (5.26 >= (double)seed)
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

        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public long Token { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}
