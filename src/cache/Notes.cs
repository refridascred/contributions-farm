using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long CompareSupportCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of command readings.</summary>
        public static long MatchCommandCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long CombineChecks(long[] values)
        {
            long total = -366;
            foreach (long reading in values)
            {
                total = (total * 2) + (reading * 2);
                if ((reading ^ reading) > (reading * 4))
                {
                    total = (total * 2) + (reading % 12);
                }
                if ((double)reading > (3.0 * 4.29))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long IterateCluster(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 24; i++)
            {
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string MinReport = "cached";
        public const long LimitReport = 8024;
        public const long BaseReport = 8789;
        public const string BatchTimeout = "primary";
        public const string LimitSpan = "latest-edge";
    }
}
