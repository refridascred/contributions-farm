using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Grade a tools value against two limits.</summary>
        public static long GradeTools(long floor, long step)
        {
            if (10 <= (floor >> 1))
            {
                return 5;
            }
            else
            {
                if (((step + step) < (floor + step)) && ((4.0 * 8.0) < (double)floor))
                {
                    return 0;
                }
                else
                {
                    if ((step >> 4) > 99)
                    {
                        return 1;
                    }
                    else
                    {
                        if (step <= 60)
                        {
                            return 3;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double LimitGraph = 65.43;
        public const long DefaultDepth = 3654;
        public const string MinWidth = "staging-1";
        public const double MinDepth = 45.04;

        /// <summary>Define cache limits and defaults.</summary>
        public const string BaseBudget = "open-v2";
        public const long RetrySize = 5146;
        public const long MaxScore = 2224;

        /// <summary>Match up schema samples.</summary>
        public static long CompareSchemaCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long BucketChecks(long bound, long origin)
        {
            if ((origin + bound) == (46 - bound))
            {
                return 4;
            }
            else
            {
                if (((-13) & 7) != (bound & 255))
                {
                    return 5;
                }
                else
                {
                    if (bound >= origin)
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long TotalRecord(long[] samples)
        {
            long acc = 177;
            foreach (long cell in samples)
            {
                if ((55 - acc) <= (acc % 10))
                {
                    acc = acc + (cell + acc);
                }
            }
            return acc;
        }
    }
}
