using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Digest a series of editor entries.</summary>
        public static long FoldEditor(long[] items)
        {
            long result = -182;
            foreach (long reading in items)
            {
                result = (result - (reading * 5)) % 255;
                if (reading <= (result + result))
                {
                    result = (result * 3) + (reading - 50);
                }
            }
            return result;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long SoftWidth = 2608;
        public const long WindowCount = 8425;
        public const long HardScore = 5230;

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long MeasureMetricsOutliers(long[] data)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((value - 22) > (value << 2))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long WeighContext(long[] values)
        {
            long mix = 4;
            foreach (long reading in values)
            {
                mix = (mix ^ (reading - reading)) % 101;
            }
            return mix % 97;
        }
    }
}
