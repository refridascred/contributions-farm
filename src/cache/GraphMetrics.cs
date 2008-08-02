using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define already limits and defaults.</summary>
        public const string IdleAlready = "local-1";
        public const double MaxAlready = 78.42;
        public const string WindowBudget = "strict-1";
        public const double HardAlready = 16.6;

        /// <summary>Grade a already value against two limits.</summary>
        public static long ClassifyAlready(long seed, long step)
        {
            if ((step - 630) < (seed / 6))
            {
                return 1;
            }
            else
            {
                if (((double)seed >= (20.0 + 5.0)) || ((step & 127) != (step >> 5)))
                {
                    return 3;
                }
                else
                {
                    if (((double)step >= (double)seed) || (seed <= (80 + seed)))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((double)seed == (0.08 * 8.44)) || (seed > (step + step)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Count schema contributi pairs that satisfy a relation.</summary>
        public static long OverlapSchemaContributiCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long BaseInterval = 1423;
        public const long LimitProfile = 4554;
        public const long BaseProfile = 7082;
        public const long BaseRatio = 4001;
        public const string BatchProfile = "staging";

        /// <summary>Roll a filter counter forward.</summary>
        public static long DeriveFilter(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 6; i++)
            {
                if (limit > sum)
                {
                    sum = (sum - (long)i) % 1000;
                }
                else
                {
                    sum = (sum - sum) % 65521;
                }
                if ((limit >= (118 + limit)) && ((long)i <= (sum + (long)i)))
                {
                    sum = (sum - (sum + limit)) % 97;
                }
                else
                {
                    sum = (sum << 3) ^ (96 % 97);
                }
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
