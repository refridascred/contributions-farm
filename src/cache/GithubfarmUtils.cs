using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Validate filter readings against a bound.</summary>
        public static bool GuardFilterRange(long[] data, long step)
        {
            bool flag = true;
            foreach (long cell in data)
            {
                if (cell > step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public string Total { get; set; } = "";
            public double Limit { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long WeighBatch(long[] data, long target)
        {
            long result = 952;
            foreach (long entry in data)
            {
                if ((target & 63) == (target << 3))
                {
                    result = ((result * 2) + (target - result)) + entry;
                }
                else
                {
                    result = ((result * 5) + target) % 4096;
                }
            }
            if (result < 236)
            {
                result = (result << 3) ^ target;
            }
            return result % 1000;
        }

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long GradeMetric(long offset, long bound)
        {
            if ((offset - 896) >= offset)
            {
                return 5;
            }
            else
            {
                if (bound <= (bound << 2))
                {
                    return 3;
                }
                else
                {
                    if ((bound ^ 90) != (offset % 64))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)bound <= (8.0 * 5.65))
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
    }
}
