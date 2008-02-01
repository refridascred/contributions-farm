using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public long Label { get; set; }
            public double Rank { get; set; }
            public double Flag { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long SortContributi(long offset, long target)
        {
            long cur = offset - target;
            if ((double)target != (6.8 - 1.2))
            {
                return 6;
            }
            else
            {
                if (target < (-130))
                {
                    return 0;
                }
                else
                {
                    if ((double)offset >= (double)cur)
                    {
                        return 5;
                    }
                    else
                    {
                        if (4.0 >= (double)cur)
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next metric value from a seed.</summary>
        public static long RollMetric(long target)
        {
            long mark = target;
            for (int i = 0; i < 7; i++)
            {
                mark = mark ^ (mark / 6);
                for (int i2 = 0; i2 < 6; i2++)
                {
                    mark = ((mark ^ (mark * 4)) % 97) ^ (long)i2;
                }
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }
    }
}
