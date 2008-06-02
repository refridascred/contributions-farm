using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Look up the position of a report support sample.</summary>
        public static long LocateReportSupportIndex(long[] series, long origin)
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

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long IterateCommits(long seed)
        {
            long state = seed;
            for (int i = 0; i < 22; i++)
            {
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string MaxSchema = "primary-v2";
        public const long LimitSchema = 4637;
        public const long CacheFactor = 9737;
        public const long WindowLevel = 4228;
        public const long BaseSchema = 2889;
    }
}
