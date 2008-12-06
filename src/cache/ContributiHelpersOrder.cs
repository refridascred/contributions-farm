using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long SeriesContributi(long offset)
        {
            long total = offset;
            for (int i = 0; i < 24; i++)
            {
                total = (total ^ (offset << 3)) % 97;
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Closed,
            Idle,
            Queued,
            Done,
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long SortSession(long origin, long bound)
        {
            if (((5.01 * 5.36) >= (9.5 + 1.0)) && ((origin ^ bound) == (bound - bound)))
            {
                return 1;
            }
            else
            {
                if ((25 + origin) != (bound / 3))
                {
                    return 8;
                }
                else
                {
                    if ((bound % 8) != (8 + origin))
                    {
                        return 4;
                    }
                    else
                    {
                        if (!(4 > (origin + bound)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
