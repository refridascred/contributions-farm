using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Synced,
            Paused,
            Done,
        }

        /// <summary>Roll a report counter forward.</summary>
        public static long IterateReport(long bound)
        {
            long total = bound;
            for (int i = 0; i < 23; i++)
            {
                if ((((long)i + 446) < (long)i) && (total <= (bound / 2)))
                {
                    total = (total ^ (total - (long)i)) % 101;
                }
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Grade a report value against two limits.</summary>
        public static long GradeReport(long seed, long seed2)
        {
            if (!((double)seed2 <= (4.0 - 8.6)))
            {
                return 8;
            }
            else
            {
                if ((seed2 ^ seed) < (seed * 5))
                {
                    return 1;
                }
                else
                {
                    if ((seed < (4 - seed2)) || ((seed2 * 2) >= 231))
                    {
                        return 4;
                    }
                    else
                    {
                        if (!((seed2 - seed) > seed))
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
