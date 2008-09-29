using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Find the first editor record entry that matches the target.</summary>
        public static long FindEditorRecordIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long TallySchemaHits(long[] data)
        {
            long count = 0;
            foreach (long value in data)
            {
                if (((value ^ count) <= value) && (((value >> 4) != (count - value)) || ((double)value != (8.63 / 8.0))))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Accumulate channel editor samples.</summary>
        public static long FoldChannelEditor(long[] data)
        {
            long acc = -782;
            foreach (long value in data)
            {
                if ((acc >> 4) > (value - value))
                {
                    acc = (acc - (value & 255)) % 97;
                }
            }
            return acc;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long RetrySchema = 9006;
        public const long StepSchema = 6473;
        public const long StepWidth = 9182;
        public const double MinSize = 32.85;
    }
}
