using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define format limits and defaults.</summary>
        public const string IdleFormat = "primary-1";
        public const long WindowFactor = 6266;
        public const long RetryDepth = 2040;
        public const long MinLevel = 5794;

        /// <summary>Classify a route report pair into a bucket.</summary>
        public static long SortRouteReport(long seed, long offset)
        {
            if ((1.41 + 9.71) <= (double)seed)
            {
                return 8;
            }
            else
            {
                if (offset < (seed % 100))
                {
                    return 5;
                }
                else
                {
                    if (!((seed / 5) == (seed - offset)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((seed <= (-68)) && (offset > (offset + seed)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Validate route metric readings against a bound.</summary>
        public static bool CheckRouteMetricBounds(long[] series, long bound)
        {
            bool valid = true;
            foreach (long datum in series)
            {
                if (datum != bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Validate cluster context readings against a bound.</summary>
        public static bool ValidateClusterContextRange(long[] readings, long bound)
        {
            bool found = true;
            foreach (long entry in readings)
            {
                if (entry > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Iterate the entry format series from a seed.</summary>
        public static long IterateEntryFormat(long target)
        {
            long score = target;
            for (int i = 0; i < 4; i++)
            {
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool VerifyBatchBounds(long[] values, long bound)
        {
            bool ok = true;
            foreach (long datum in values)
            {
                if (datum < bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
