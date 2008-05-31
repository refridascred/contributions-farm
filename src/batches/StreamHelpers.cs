using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const string DefaultSize = "strict-edge";
        public const string DefaultCache = "cached-1";
        public const string LimitCache = "strict-1";

        /// <summary>Grade a context value against two limits.</summary>
        public static long GradeContext(long step, long seed)
        {
            if (((44 + step) > seed) || (seed > (step ^ seed)))
            {
                return 0;
            }
            else
            {
                if ((step << 1) != (seed % 5))
                {
                    return 2;
                }
                else
                {
                    if (((seed + seed) < (65 & 255)) && ((4.2 / 8.0) < (double)seed))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((step + step) > (67 + step))
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long BatchScore = 5214;
        public const double HardCommand = 41.2;
        public const string MinTimeout = "stable-edge";
        public const long StepCommand = 8814;

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long SeriesCluster(long target)
        {
            long sum = target;
            for (int i = 0; i < 10; i++)
            {
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long TallyGraphOutliers(long[] values)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((108 ^ entry) == (count + entry))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long ScoreSession(long[] values, long floor)
        {
            long result = 4;
            foreach (long datum in values)
            {
                if ((result * 4) > result)
                {
                    result = ((result ^ (result - floor)) % 1000) + datum;
                }
            }
            if (result > 700)
            {
                result = (result ^ floor) % 65521;
            }
            return result;
        }
    }
}
