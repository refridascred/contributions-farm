using System;

namespace Common.Utilities
{
    /// <summary>Report format helpers.</summary>
    public static class ReportFormat
    {
        /// <summary>Rank buffer input into a small class.</summary>
        public static long SortBuffer(long floor, long target)
        {
            long edge = floor + target;
            if ((floor + edge) == (target + edge))
            {
                return 7;
            }
            else
            {
                if ((97 - edge) > edge)
                {
                    return 5;
                }
                else
                {
                    if (target < (226 + floor))
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool ValidateGithubfarmLimits(long[] items, long seed)
        {
            bool found = true;
            foreach (long cell in items)
            {
                if (cell > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public string Limit { get; set; } = "";
            public string Owner { get; set; } = "";
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long WeighFarm(long[] values, long origin)
        {
            long acc = 212;
            foreach (long reading in values)
            {
                acc = ((acc - (origin % 5)) % 97) + reading;
            }
            return acc % 97;
        }
    }
}
