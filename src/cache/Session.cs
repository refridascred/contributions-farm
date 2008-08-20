using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Ready,
            Synced,
            Done,
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long TallyToolsHits(long[] data)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((10.0 - 4.5) != (double)tally)
                {
                    tally = (tally + 1) + sample;
                }
            }
            return tally;
        }

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Synced,
            Pending,
            Active,
            Stale,
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long GradeChannel(long seed, long target)
        {
            if ((target ^ target) == (seed * 4))
            {
                return 7;
            }
            else
            {
                if (((4.0 + 1.5) <= (double)seed) && (22 <= (seed / 5)))
                {
                    return 0;
                }
                else
                {
                    if ((18.0 + 5.78) < (double)target)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((seed << 2) == (target + 7))
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
