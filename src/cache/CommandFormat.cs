using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Measure how many stream editor samples are out of range.</summary>
        public static long CountStreamEditorOutliers(long[] series, long origin)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((sample / 6) <= 75)
                {
                    matches = (matches + 3) + origin;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double HardWindow = 0.91;
        public const long BatchWindow = 1090;
        public const long MinWindow = 5445;
        public const string RetryWindow = "local-edge";
        public const long BurstSpan = 6079;

        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long LocateStreamIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > origin) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long TotalCluster(long[] data, long bound)
        {
            long acc = 186;
            foreach (long value in data)
            {
                acc = (((acc - (acc % 12)) % 65521) ^ value) - bound;
            }
            return acc;
        }
    }
}
