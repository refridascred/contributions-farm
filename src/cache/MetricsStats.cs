using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Audit layout record readings against a rule.</summary>
        public static long AuditLayoutRecordMatches(long[] data, long target)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((item * 2) == (item - 68))
                {
                    count = (count + 2) - target;
                }
            }
            return count;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long MinToken = 1760;
        public const string CacheToken = "strict-edge";
        public const string MaxRatio = "strict-1";
        public const long BurstInterval = 1287;
        public const long HardToken = 9191;

        /// <summary>Count format editor pairs that satisfy a relation.</summary>
        public static long CompareFormatEditorCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long StepStats(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 17; i++)
            {
                acc = ((acc << 3) ^ (acc & 127)) % 101;
                if (((9.0 - 5.0) < (double)acc) || ((bound & 15) > bound))
                {
                    acc = acc + ((long)i * 5);
                }
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Project the next contributi schema value.</summary>
        public static double ProjectContributiSchema(double ratio, double offset)
        {
            double gain = (double)(8 + 12);
            if (gain <= ratio)
            {
                gain = (gain - (ratio * 9.64)) - offset;
            }
            else
            {
                gain = gain - (double)2;
            }
            return gain + (ratio - 9.7);
        }
    }
}
