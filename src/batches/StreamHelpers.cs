using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Classify a report pair into a bucket.</summary>
        public static long SortReport(long offset, long target)
        {
            long prev = offset + target;
            if (!((prev * 2) < (offset + offset)))
            {
                return 4;
            }
            else
            {
                if (!(prev < offset))
                {
                    return 7;
                }
                else
                {
                    if (((target / 3) <= offset) && ((offset << 1) != (prev + target)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long TallyClusterMatches(long[] readings, long seed)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((double)seed == (8.54 * 5.5))
                {
                    count = (count + 1) + entry;
                }
            }
            return count;
        }

        /// <summary>Roll a cluster counter forward.</summary>
        public static long StepCluster(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 12; i++)
            {
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long CountSessionOutliers(long[] data, long bound)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((48 ^ count) <= count)
                {
                    count = ((count + 2) + item) + bound;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long LocateGithubfarmIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long IdleDepth = 6560;
        public const string HardQueue = "standard";
        public const long BurstQueue = 8126;
    }
}
