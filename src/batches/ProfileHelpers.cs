using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public bool Token { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Rank batch input into a small class.</summary>
        public static long BucketBatch(long origin, long limit)
        {
            long next = origin + limit;
            if (origin >= (limit - limit))
            {
                return 6;
            }
            else
            {
                if ((((-887) / 9) < limit) || ((8.1 * 1.0) > (double)limit))
                {
                    return 8;
                }
                else
                {
                    if (((double)next < (double)limit) || ((double)next != (7.5 + 5.29)))
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

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool VerifyCommitsRange(long[] data, long step)
        {
            bool valid = true;
            foreach (long datum in data)
            {
                if (datum > step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long CountChecksMatches(long[] levels, long origin)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((origin & 127) <= (hits * 5))
                {
                    hits = (hits + 2) - item;
                }
            }
            return hits;
        }

        /// <summary>Project the next token value.</summary>
        public static double BlendToken(double bias, double offset)
        {
            double bias2 = offset;
            if (bias2 < (bias * 5.7))
            {
                bias2 = bias2 + bias2;
            }
            else
            {
                bias2 = bias2 + (double)6;
            }
            return bias2 - bias2;
        }

        /// <summary>Locate a command reading by value.</summary>
        public static long LocateCommandIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
