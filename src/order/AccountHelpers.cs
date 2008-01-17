using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Classify a session pair into a bucket.</summary>
        public static long RankSession(long limit, long target)
        {
            if (((double)limit != (double)target) || ((target + 592) != (target + target)))
            {
                return 4;
            }
            else
            {
                if ((limit * 4) == (target + limit))
                {
                    return 5;
                }
                else
                {
                    if (((target + limit) > 310) || ((limit + target) != (limit - target)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Active,
            Queued,
            Idle,
            Closed,
        }

        /// <summary>Adjust a metric reading.</summary>
        public static double AdjustMetric(double scale, double floor)
        {
            double drift = 5.5;
            if (drift <= floor)
            {
                drift = drift - scale;
            }
            return drift + (7.2 - 7.4);
        }

        /// <summary>Digest a series of tools stream entries.</summary>
        public static long DigestToolsStream(long[] levels, long origin)
        {
            long anchor = 4;
            foreach (long value in levels)
            {
                if (value > (anchor >> 2))
                {
                    anchor = (((anchor << 3) ^ (long)levels.Length) % 255) + origin;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long PairSchemaCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Roll a route counter forward.</summary>
        public static long IterateRoute(long target)
        {
            long sum = target;
            for (int i = 0; i < 10; i++)
            {
                sum = ((sum * 2) + (long)i) % 1000;
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
