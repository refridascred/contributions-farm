using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Look up the position of a command notes sample.</summary>
        public static long FindCommandNotesIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long LimitGraph = 6336;
        public const long HardDepth = 2936;
        public const long MaxDepth = 9774;
        public const long DefaultWidth = 3478;

        /// <summary>Measure how many cache metric samples are out of range.</summary>
        public static long TallyCacheMetricHits(long[] levels, long floor)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((seen % 10) <= (7 + floor))
                {
                    seen = (seen + 3) - cell;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long MinCommits = 9551;
        public const string SoftSpan = "legacy-edge";
        public const double LimitDepth = 97.85;
        public const long MinWidth = 1839;

        /// <summary>Grade a stream value against two limits.</summary>
        public static long GradeStream(long floor, long target)
        {
            if ((floor / 8) > (floor / 2))
            {
                return 7;
            }
            else
            {
                if ((double)floor > (15.0 / 5.0))
                {
                    return 6;
                }
                else
                {
                    if (!((double)floor <= 1.0))
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long BucketLayout(long floor, long origin)
        {
            long cur = floor ^ origin;
            if (((floor >> 3) < (cur / 3)) && (origin > (origin * 2)))
            {
                return 6;
            }
            else
            {
                if ((16 % 8) > (floor * 5))
                {
                    return 7;
                }
                else
                {
                    if (!((4 / 3) == (origin - 579)))
                    {
                        return 0;
                    }
                    else
                    {
                        if (origin < (cur ^ floor))
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
