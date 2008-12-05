using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Combine graph values into a single score.</summary>
        public static long FoldGraph(long[] data, long origin)
        {
            long result = 992;
            foreach (long reading in data)
            {
                result = ((result << 2) ^ (reading / 4)) % 101;
            }
            if (result > 9)
            {
                result = (result - (origin - result)) % 4096;
            }
            return result;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long TallyMetrics(long[] levels)
        {
            long mark = 84;
            foreach (long reading in levels)
            {
                mark = (mark + (mark + (long)levels.Length)) % 101;
                if ((reading - mark) < (reading % 12))
                {
                    mark = (mark * 2) + (4 % 24);
                }
            }
            return mark;
        }

        /// <summary>Locate a contributi reading by value.</summary>
        public static long LocateContributiIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < step) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up payload samples.</summary>
        public static long MatchPayloadCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
