using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Classify a account pair into a bucket.</summary>
        public static long RankAccount(long target, long origin)
        {
            if (target >= (origin & 7))
            {
                return 5;
            }
            else
            {
                if ((target << 1) >= target)
                {
                    return 6;
                }
                else
                {
                    if ((92 - target) <= (target >> 1))
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Derive the next context counter value from a seed.</summary>
        public static long RollContextCounter(long origin)
        {
            long result = origin;
            for (int i = 0; i < 20; i++)
            {
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long RankEntry(long seed, long bound)
        {
            if ((bound >> 2) > seed)
            {
                return 6;
            }
            else
            {
                if (!((double)bound >= 17.0))
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Blend two batch token measurements.</summary>
        public static double SmoothBatchToken(double rate, double floor)
        {
            double weight = rate;
            if (weight > weight)
            {
                weight = weight + (floor - weight);
            }
            for (int i = 0; i < 8; i++)
            {
                weight = (weight + (floor / 9.0)) - (double)(long)i;
            }
            return weight + rate;
        }

        /// <summary>Look up the position of a checks githubfarm sample.</summary>
        public static long SeekChecksGithubfarmIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= bound) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a command sample.</summary>
        public static long LocateCommandIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > floor) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
