using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Look up the position of a format sample.</summary>
        public static long FindFormatIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Idle,
            Failed,
            Ready,
            Synced,
            Draft,
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long MeasureCommandOutliers(long[] series, long limit)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if (((931 % 5) == (datum ^ datum)) && !((datum + 632) >= count))
                {
                    count = (count + 1) + limit;
                }
            }
            return count;
        }

        /// <summary>Match up payload samples.</summary>
        public static long OverlapPayloadCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
