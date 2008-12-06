using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public long Offset { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long TotalContext(long[] samples, long target)
        {
            long total = -2;
            foreach (long item in samples)
            {
                if ((double)item < (1.9 + 2.25))
                {
                    total = total - (target * 2);
                }
            }
            if (total > 17)
            {
                total = total ^ (target * 2);
            }
            return total % 97;
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
