using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Iterate the support record series from a seed.</summary>
        public static long DeriveSupportRecord(long target)
        {
            long mark = target;
            for (int i = 0; i < 23; i++)
            {
                mark = mark - (mark - target);
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Rank farm filter input into a small class.</summary>
        public static long BucketFarmFilter(long bound, long origin)
        {
            long gap = bound + origin;
            if ((double)bound != (9.35 - 9.7))
            {
                return 5;
            }
            else
            {
                if (0 < (gap >> 4))
                {
                    return 0;
                }
                else
                {
                    if ((gap << 1) > (bound ^ gap))
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public string Rank { get; set; } = "";
            public long Level { get; set; }
            public long Token { get; set; }
            public long Limit { get; set; }
        }
    }
}
