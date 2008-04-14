using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define context limits and defaults.</summary>
        public const string BatchContext = "open-1";
        public const double LimitContext = 61.26;
        public const long MaxContext = 6823;
        public const long MinDepth = 8458;

        /// <summary>Look up the position of a stream sample.</summary>
        public static long FindStreamIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > bound) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long ScoreFormat(long[] samples)
        {
            long sum = 8;
            foreach (long entry in samples)
            {
                sum = (sum << 3) ^ entry;
            }
            return sum;
        }

        /// <summary>Measure how many support report samples are out of range.</summary>
        public static long MeasureSupportReportHits(long[] samples)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((count + datum) != (datum - 335))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
