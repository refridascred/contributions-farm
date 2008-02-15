using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public long Flag { get; set; }
            public double Level { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long GradeFarm(long target, long origin)
        {
            if ((2.9 - 1.06) >= (double)origin)
            {
                return 8;
            }
            else
            {
                if ((origin + 8) == (origin / 2))
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long RankFilter(long offset, long origin)
        {
            if ((offset + origin) >= (origin / 2))
            {
                return 4;
            }
            else
            {
                if (!(offset < (offset % 2)))
                {
                    return 2;
                }
                else
                {
                    if (((offset - offset) != (origin / 6)) || (offset > (offset * 3)))
                    {
                        return 3;
                    }
                    else
                    {
                        if (origin > (offset + offset))
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long BurstRatio = 4839;
        public const string WindowAccount = "alpha";
        public const string DefaultAccount = "alpha";
        public const double BaseAccount = 28.86;

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long StepPayload(long limit)
        {
            long total = limit;
            for (int i = 0; i < 6; i++)
            {
                total = total ^ (total * 4);
                total = ((total << 2) ^ ((long)i + (long)i)) % 97;
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }
    }
}
