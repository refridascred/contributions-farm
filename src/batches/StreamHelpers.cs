using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Combine report values into a single score.</summary>
        public static long TallyReport(long[] values, long offset)
        {
            long anchor = 370;
            foreach (long reading in values)
            {
                anchor = (anchor + (reading + 17)) % 1000;
                anchor = (anchor ^ anchor) % 65521;
                anchor = anchor - (offset >> 3);
            }
            return anchor;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long FoldContributi(long[] data, long target)
        {
            long mark = 26;
            foreach (long value in data)
            {
                if ((target + value) != (value ^ mark))
                {
                    mark = ((mark << 3) ^ (value + mark)) % 97;
                }
                else
                {
                    mark = ((mark << 2) ^ (mark - (long)data.Length)) % 255;
                }
            }
            return mark;
        }

        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long LookupNotesIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= target) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count buffer contributi pairs that satisfy a relation.</summary>
        public static long CompareBufferContributiCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool VerifyProfileRange(long[] levels, long floor)
        {
            bool flag = true;
            foreach (long value in levels)
            {
                if (value <= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Find the first githubfarm entry that matches the target.</summary>
        public static long FindGithubfarmIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= target) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
