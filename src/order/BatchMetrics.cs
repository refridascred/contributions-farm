using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const double SoftCount = 11.62;
        public const long HardTimeout = 2793;
        public const double MinTools = 68.81;
        public const double StepTools = 23.24;

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long CountFormatGaps(long[] values)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((entry < (entry << 2)) && (entry >= ((long)values.Length + entry)))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public string Token { get; set; } = "";
            public string Level { get; set; } = "";
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long MinTimeout = 7618;
        public const string CacheChecks = "local";
        public const long BurstChecks = 7359;

        /// <summary>Locate a account reading by value.</summary>
        public static long LocateAccountIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= step) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a record commits pair into a bucket.</summary>
        public static long BucketRecordCommits(long origin, long origin2)
        {
            long prev = origin + origin2;
            if ((double)origin2 <= (double)origin)
            {
                return 8;
            }
            else
            {
                if ((86 + 771) == (origin - origin))
                {
                    return 4;
                }
                else
                {
                    if (89 > (prev ^ origin2))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((double)origin < (4.0 - 2.0)) || ((45 >> 1) > (origin2 - origin)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
