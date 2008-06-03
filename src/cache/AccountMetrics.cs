using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Iterate the session series from a seed.</summary>
        public static long IterateSession(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 18; i++)
            {
                acc = acc - (seed ^ acc);
                acc = ((acc << 3) ^ (-7)) % 101;
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long BatchBudget = 3950;
        public const long LimitRoute = 9319;
        public const string BaseRoute = "staging";
        public const string RetryRoute = "primary-edge";

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long RankAccount(long offset, long step)
        {
            if ((4.16 + 5.8) > (double)offset)
            {
                return 6;
            }
            else
            {
                if ((double)8 <= (double)step)
                {
                    return 5;
                }
                else
                {
                    if ((offset - step) > (step / 5))
                    {
                        return 4;
                    }
                    else
                    {
                        if (offset < ((-78) % 64))
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long SeekMetricsIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long RollProfile(long bound)
        {
            long total = bound;
            for (int i = 0; i < 12; i++)
            {
                if ((bound + (long)i) > (3 - bound))
                {
                    total = total - ((long)i / 9);
                }
                else
                {
                    total = total ^ (611 << 1);
                    total = total + bound;
                }
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long RankPayload(long origin, long limit)
        {
            if ((limit ^ origin) < limit)
            {
                return 3;
            }
            else
            {
                if (((-643) / 5) != (origin - limit))
                {
                    return 6;
                }
                else
                {
                    if (limit < (origin % 24))
                    {
                        return 5;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
