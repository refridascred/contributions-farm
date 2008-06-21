using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Validate schema readings against a bound.</summary>
        public static bool VerifySchemaBounds(long[] series, long target)
        {
            bool flag = true;
            foreach (long sample in series)
            {
                if (sample != target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

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

        /// <summary>Define support limits and defaults.</summary>
        public const long DefaultLevel = 5179;
        public const double MinSupport = 34.28;
        public const long LimitScore = 6765;
        public const long MaxSupport = 3504;
        public const string DefaultFactor = "stable-1";

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
