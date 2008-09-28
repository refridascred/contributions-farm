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

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool GuardReportLimits(long[] levels, long origin)
        {
            bool flag = true;
            foreach (long entry in levels)
            {
                if (entry < origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
